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
        public List<bool> IsNotNullConstraints { get; private set; }
        public List<bool> IsPrimaryKeyColumns { get; private set; }
        public List<bool> IsUniqueColumns { get; private set; }

        public AddTableDialog()
        {
            InitializeComponent();
            this.ShowIcon = false;
            ColumnNames = new List<string>();
            DataTypes = new List<string>();
            IsNotNullConstraints = new List<bool>();
            IsPrimaryKeyColumns = new List<bool>();
            IsUniqueColumns = new List<bool>();
        }

        private void AddTableDialog_Load(object sender, EventArgs e)
        {

        }

        private void AddColumnButton_Click(object sender, EventArgs e)
        {
            string columnName = ColumnNameTextBox.Text.Trim();
            string dataType = DataTypeComboBox.Text.Trim();
            bool isNotNull = NotNullCheckBox.Checked;
            bool isPrimaryKey = PrimaryKeyCheckBox.Checked;
            bool isUnique = UniqueCheckBox.Checked;


            if (!string.IsNullOrWhiteSpace(columnName) && !string.IsNullOrWhiteSpace(dataType))
            {
                ColumnNames.Add(columnName);
                DataTypes.Add(dataType);
                IsNotNullConstraints.Add(isNotNull);
                IsPrimaryKeyColumns.Add(isPrimaryKey);
                IsUniqueColumns.Add(isUnique);
                ColumnsListBox.Items.Add($"{columnName} ({dataType}) {isNotNull} {isPrimaryKey} {isUnique}");

                ColumnNameTextBox.Clear();
                DataTypeComboBox.SelectedIndex = -1;
                UniqueCheckBox.Checked = false;
                NotNullCheckBox.Checked = false;
                PrimaryKeyCheckBox.Checked = false;
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
                IsNotNullConstraints.RemoveAt(selectedIndex);
                IsPrimaryKeyColumns.RemoveAt(selectedIndex);
                IsUniqueColumns.RemoveAt(selectedIndex);
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

        private void PrimaryKeyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PrimaryKeyCheckBox.Checked)
            {
                NotNullCheckBox.Checked = true;
                NotNullCheckBox.Enabled = false;
                UniqueCheckBox.Checked = false;
                UniqueCheckBox.Enabled = false;
            }
            else
            {
                NotNullCheckBox.Checked = false;
                NotNullCheckBox.Enabled = true;
                UniqueCheckBox.Enabled = true;
            }
        }

        private void UniqueCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (UniqueCheckBox.Checked)
            {
                PrimaryKeyCheckBox.Checked = false;
                PrimaryKeyCheckBox.Enabled = false;
            }
            else
            {
                PrimaryKeyCheckBox.Enabled = true;
            }
        }
    }
}
