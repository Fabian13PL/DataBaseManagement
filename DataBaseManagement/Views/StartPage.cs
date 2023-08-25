using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DataBaseManagement.Views
{
    public partial class StartPage : Form
    {
        private string value;
        public StartPage()
        {
            InitializeComponent();
            this.ShowIcon = false;
        }

        private void DataBaseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            value = DataBaseList.Text.ToString();
        }

        private void StartPage_Load(object sender, EventArgs e)
        {
            RefreshDatabaseList();
        }
        private void RefreshDatabaseList()
        {
            using (SqlConnection connection = new SqlConnection($"Data Source=localhost;Initial Catalog=master;Integrated Security=True"))
            {
                DataBaseList.Items.Clear();
                connection.Open();
                string sql = $"SELECT name FROM master.sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    List<string> databaseList = new List<string>();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string databaseName = reader["name"].ToString();
                            databaseList.Add(databaseName);
                        }
                    }

                    foreach (var databaseName in databaseList)
                    {
                        DataBaseList.Items.Add(databaseName);
                    }
                }
                connection.Close();
            }
        }

        private void AddDataBase_Click(object sender, EventArgs e)
        {
            AddDataBase addDataBaseForm = new AddDataBase();
            addDataBaseForm.ShowDialog();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DataBaseList_MouseClick(object sender, MouseEventArgs e)
        {
            RefreshDatabaseList();
        }

        private void ButtonSelectDataBase_Click(object sender, EventArgs e)
        {
            string SelectedDatabase = DataBaseList.Text.Trim();
            if (!string.IsNullOrWhiteSpace(SelectedDatabase))
            {
                ManageTablesDialog manageTablesDialogForm = new ManageTablesDialog(DataBaseList.Text.ToString());
                manageTablesDialogForm.ShowDialog();
            }
        }
        
        private void DataBaseList_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}