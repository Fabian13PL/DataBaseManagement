using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DataBaseManagement.Views
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void DataBaseList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StartPage_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection($"Data Source=localhost;Initial Catalog=master;Integrated Security=True"))
            {
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
    }
}
