using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DataBaseManagement.Views
{
    public partial class AddTableDialog : Form
    {
        public string TableName { get; private set; }
        public List<string> ColumnNames { get; private set; }
        public List<string> DataTypes { get; private set; }

        public AddTableDialog()
        {
            InitializeComponent();
            ColumnNames = new List<string>();
            DataTypes = new List<string>();
        }

        private void AddTableDialog_Load(object sender, EventArgs e)
        {
            // Load any necessary data or perform initialization if needed
        }

        private void AddColumnButton_Click(object sender, EventArgs e)
        {
            string columnName = ColumnNameTextBox.Text.Trim();
            string dataType = DataTypeComboBox.Text.Trim();

            if (!string.IsNullOrWhiteSpace(columnName) && !string.IsNullOrWhiteSpace(dataType))
            {
                ColumnNames.Add(columnName);
                DataTypes.Add(dataType);
                ColumnsListBox.Items.Add($"{columnName} ({dataType})");

                ColumnNameTextBox.Clear();
                DataTypeComboBox.SelectedIndex = -1;
            }
        }

        private void RemoveColumnButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = ColumnsListBox.SelectedIndex;
            if (selectedIndex >= 0)
            {
                ColumnNames.RemoveAt(selectedIndex);
                DataTypes.RemoveAt(selectedIndex);
                ColumnsListBox.Items.RemoveAt(selectedIndex);
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            TableName = TableNameTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(TableName) || ColumnNames.Count == 0)
            {
                MessageBox.Show("Wprowadź nazwę tabeli i dodaj co najmniej jedną kolumnę.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
