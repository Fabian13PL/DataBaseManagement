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
            this.ShowIcon = false;
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
                                List<bool> IsNotNullConstraints = addTableDialog.IsNotNullConstraints;
                                List<bool> IsPrimaryKeyColumns = addTableDialog.IsPrimaryKeyColumns;
                                List<bool> IsUniqueColumns = addTableDialog.IsUniqueColumns;

                                using (DatabaseContext contextC0 = new DatabaseContext())
                                {
                                    contextC0.CreateTable(databaseList, tableName, columnNames, dataTypes, IsNotNullConstraints, IsPrimaryKeyColumns, IsUniqueColumns);
                                    RefreshComboBoxTableNames();
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
                            RefreshComboBoxTableNames();
                        }
                        break;
                    case 2: // Edytuj kolumny
                        if (comboBoxTableNames.SelectedItem != null)
                        {
                            string selectedTableNameC2 = comboBoxTableNames.SelectedItem.ToString();

                            EditColumnsDialog editColumnsDialog = new EditColumnsDialog(selectedTableNameC2);
                            if (editColumnsDialog.ShowDialog() == DialogResult.OK)
                            {
                                List<string> columnNames = editColumnsDialog.ColumnNames;
                                List<string> dataTypes = editColumnsDialog.DataTypes;
                                List<bool> IsNotNullConstraints = editColumnsDialog.IsNotNullConstraints;
                                List<bool> IsPrimaryKeyColumns = editColumnsDialog.IsPrimaryKeyColumns;
                                List<bool> IsUniqueColumns = editColumnsDialog.IsUniqueColumns;

                                using (DatabaseContext contextC2 = new DatabaseContext())
                                {
                                    contextC2.EditTable(databaseList, selectedTableNameC2, columnNames, dataTypes, IsNotNullConstraints, IsPrimaryKeyColumns, IsUniqueColumns);
                                    RefreshComboBoxTableNames();
                                }

                                dataGridRefresh();
                            }
                        }
                        RefreshComboBoxTableNames();
                        break;
                    case 3: // Dodaj wiersz
                        if (comboBoxTableNames.SelectedItem != null)
                        {
                            string selectedTableNameC3 = comboBoxTableNames.SelectedItem.ToString();

                            using (DatabaseContext contextC3 = new DatabaseContext())
                            {
                                Table selectedTableC3 = context.Tables.FirstOrDefault(table => table.Name == selectedTableNameC3);
                                if (selectedTableC3 != null)
                                {
                                    List<string> columnNames = selectedTableC3.Columns.Select(column => column.ColumnName).ToList();
                                    AddRowDialog addRowDialog = new AddRowDialog(columnNames);

                                    if (addRowDialog.ShowDialog() == DialogResult.OK)
                                    {
                                        try
                                        {
                                            using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=master;Integrated Security=True"))
                                            {
                                                connection.Open();

                                                string insertQuery = $"INSERT INTO {selectedTableC3.Name} ({string.Join(", ", columnNames)}) VALUES ({string.Join(", ", addRowDialog.RowValues.ConvertAll(value => $"@{value}"))})";

                                                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                                                {
                                                    for (int i = 0; i < columnNames.Count; i++)
                                                    {
                                                        command.Parameters.AddWithValue($"@{columnNames[i]}", addRowDialog.RowValues[i]);
                                                    }

                                                    int rowsAffected = command.ExecuteNonQuery();

                                                    if (rowsAffected > 0)
                                                    {
                                                        MessageBox.Show("Wiersz został dodany.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        dataGridRefresh(); // Odświeżanie danych w interfejsie użytkownika
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Nie udało się dodać wiersza.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                    }
                                                }
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show("Wystąpił błąd: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case 4: // Usuń wiersz
                        if (comboBoxTableNames.SelectedItem != null)
                        {
                            using (DatabaseContext contextC4 = new DatabaseContext())
                            {
                                string selectedTableNameC4 = comboBoxTableNames.SelectedItem.ToString();
                                Table selectedTableC4 = contextC4.Tables.FirstOrDefault(table => table.Name == selectedTableNameC4);

                                if (selectedTableC4 != null)
                                {
                                    DeleteRowDialog deleteRowDialog = new DeleteRowDialog(selectedTableC4);
                                    if (deleteRowDialog.ShowDialog() == DialogResult.OK)
                                    {
                                        if (deleteRowDialog.ConfirmDelete)
                                        {
                                            try
                                            {
                                                using (SqlConnection connection = new SqlConnection("Data Source=localhost;Initial Catalog=master;Integrated Security=True"))
                                                {
                                                    connection.Open();

                                                    string deleteQuery = $"DELETE FROM {selectedTableC4.Name} WHERE ID = @ID"; // Przyjmuję, że ID to nazwa kolumny identyfikującej wiersze

                                                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                                                    {
                                                        command.Parameters.AddWithValue("@ID", deleteRowDialog.SelectedRowID);

                                                        int rowsAffected = command.ExecuteNonQuery();

                                                        if (rowsAffected > 0)
                                                        {
                                                            MessageBox.Show("Wiersz został usunięty.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                            dataGridRefresh(); // Odświeżanie danych w interfejsie użytkownika
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Nie udało się usunąć wiersza.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        }
                                                    }
                                                }
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show("Wystąpił błąd: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                    }
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
        private void RefreshComboBoxTableNames()
        {
            comboBoxTableNames.Items.Clear();

            using (SqlConnection connection = new SqlConnection($"Data Source=localhost;Initial Catalog=master;Integrated Security=True"))
            {
                connection.Open();
                string sql = $"SELECT name FROM {databaseList}.sys.tables";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string tableName = reader["name"].ToString();
                            comboBoxTableNames.Items.Add(tableName);
                        }
                    }
                }
                connection.Close();
            }
        }

    }
}
