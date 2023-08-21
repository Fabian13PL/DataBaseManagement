using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

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
            using (var context = new DatabaseContext())
            {
                var databaseList = context.Database.SqlQuery<string>("SELECT name FROM master.sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')").ToList();

                foreach (var databaseName in databaseList)
                {
                    DataBaseList.Items.Add(databaseName);
                }
            }
        }


        private void AddDataBase_Click(object sender, EventArgs e)
        {
            AddDataBase addDataBaseForm = new AddDataBase();
            addDataBaseForm.ShowDialog();
        }
    }
}
