using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseManagement.Views
{
    public partial class ManageTablesDialog : Form
    {
        private String databaseList;

        public ManageTablesDialog(String databaseList)
        {
            InitializeComponent();
            this.databaseList = databaseList; 
        }

        private DataTable tableData; 

        private void ManageTablesDialog_Load(object sender, EventArgs e)
        {
            tableData = new DataTable();
            using (SqlConnection connection = new SqlConnection($"Data Source=localhost;Initial Catalog=master;Integrated Security=True"))
            {
                connection.Open();
                string sql = $"SELECT name FROM {databaseList}.sys.tables";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    List<string> tableList = new List<string>();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string tableNameReader = reader["name"].ToString();
                            tableList.Add(tableNameReader);
                        }
                    }
                    foreach (var tableName in tableList)
                    {
                        comboBoxTableNames.Items.Add(tableName);
                    }
                    connection.Close();
                }
                //dataGridRefresh();
            }
        }

        private void dataGridRefresh()
        {
            string selectedTableName = comboBoxTableNames.Text.ToString();
            if (selectedTableName != null)
            {
                using (SqlConnection connection = new SqlConnection($"Data Source=localhost;Initial Catalog=master;Integrated Security=True"))
                {
                    connection.Open();

                    string sql = $"USE {databaseList} SELECT * FROM {selectedTableName}";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable selectedTable = new DataTable();
                            selectedTable.Load(reader);
                            dataGridView.DataSource = selectedTable;
                        }
                    }
                    connection.Close();
                }
            }
        }

        private void comboBoxTableNames_SelectedValueChanged(object sender, EventArgs e)
        {
            dataGridRefresh();
        }
        private void comboBoxTableNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridRefresh();
        }

        private void SelectActionButton_Click(object sender, EventArgs e)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                string selectedTableName = comboBoxTableNames.Text.ToString(); // Get the selected table name

                switch (SelectActionComboBox.SelectedIndex)
                {
                    case 0: // Dodaj nową tabelę
                        using (AddTableDialog addTableDialog = new AddTableDialog())
                        {
                            if (addTableDialog.ShowDialog() == DialogResult.OK)
                            {
                                string tableName = addTableDialog.TableName;
                                List<string> columnNames = addTableDialog.ColumnNames;
                                List<string> dataTypes = addTableDialog.DataTypes;

                                using (DatabaseContext contextC0 = new DatabaseContext())
                                {
                                    contextC0.CreateTable(tableName, columnNames, dataTypes, databaseList);
                                    // Aktualizuj ComboBox lub wykonaj inne niezbędne działania
                                }
                            }
                        }
                        break;
                    case 1: // Usuń wybraną tabelę
                        Table tableToDelete = context.Tables.FirstOrDefault(t => t.Name == selectedTableName);
                        if (tableToDelete != null)
                        {
                            context.Tables.Remove(tableToDelete);
                            context.SaveChanges();
                            // Update the ComboBox or take other necessary actions
                        }
                        break;
                    case 2: // Edytuj kolumny
                            // Kod obsługi edycji kolumn
                        break;
                    case 3: // Dodaj wiersz
                            // Kod obsługi dodawania wiersza
                        break;
                    case 4: // Usuń wiersz
                        if (dataGridView.SelectedRows.Count > 0)
                        {
                            DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                            int rowId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                            Table selectedTableC4 = context.Tables.FirstOrDefault(t => t.Name == selectedTableName);
                            if (selectedTableC4 != null)
                            {
                                Row rowToDelete = selectedTableC4.Rows.FirstOrDefault(r => r.Id == rowId);
                                if (rowToDelete != null)
                                {
                                    context.DeleteRow(rowToDelete);
                                    // Update the ComboBox or take other necessary actions
                                }
                            }
                        }
                        break;


                    case 5: // Eksportuj tabelę do CSV
                        Table selectedTable = context.Tables.FirstOrDefault(t => t.Name == selectedTableName);
                        if (selectedTable != null)
                        {
                            SaveFileDialog saveFileDialog = new SaveFileDialog();
                            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                string filePath = saveFileDialog.FileName;
                                context.ExportToCSV(selectedTable, filePath);
                                // Show a message or take other necessary actions
                            }
                        }
                        break;

                    default:
                        break;
                }
            }
        }


    }
}
