using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseManagement.Views
{
    public partial class AddDataBase : Form
    {
        public AddDataBase()
        {
            InitializeComponent();
        }

        private void buttonCreateDatabase_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string description = textBoxDescription.Text;
            string serverName = textBoxServerName.Text;

            DatabaseCreator databaseCreator = new DatabaseCreator();
            databaseCreator.CreateDatabase(name, description, serverName);

            this.Close();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
