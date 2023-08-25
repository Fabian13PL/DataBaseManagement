using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace DataBaseManagement.Views
{
    public partial class EditColumnsDialog : Form
    {
        public List<string> ColumnNames { get; private set; }
        public List<string> DataTypes { get; private set; }
        public List<bool> IsNotNullConstraints { get; private set; }
        public List<bool> IsPrimaryKeyColumns { get; private set; }
        public List<bool> IsUniqueColumns { get; private set; }

        public EditColumnsDialog(string selectedTableName)
        {
            InitializeComponent();

            ColumnNames = new List<string>();
            DataTypes = new List<string>();
            IsNotNullConstraints = new List<bool>();
            IsPrimaryKeyColumns = new List<bool>();
            IsUniqueColumns = new List<bool>();

            TableNameTextBox.Text = selectedTableName;

            using (var context = new DatabaseContext())
            {
                var selectedTables = context.Tables.Where(t => t.Name == selectedTableName).ToList();

                if (selectedTables.Any())
                {
                    var selectedTable = selectedTables.First();

                    foreach (var column in selectedTable.Columns)
                    {
                        ColumnNames.Add(column.ColumnName);
                        DataTypes.Add(column.DataType);
                        IsNotNullConstraints.Add(column.IsNotNull);
                        IsPrimaryKeyColumns.Add(column.IsPrimaryKey);
                        IsUniqueColumns.Add(column.IsUnique);
                        ColumnsListBox.Items.Add($"{column.ColumnName} ({column.DataType})");
                    }
                }
            }
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
            if (ColumnNames.Count == 0)
            {
                MessageBox.Show("Dodaj co najmniej jedną kolumnę.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void EditColumnButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = ColumnsListBox.SelectedIndex;

            if (selectedIndex >= 0)
            {
                ColumnNames[selectedIndex] = ColumnNameTextBox.Text.Trim();
                DataTypes[selectedIndex] = DataTypeComboBox.Text.Trim();
                IsNotNullConstraints[selectedIndex] = NotNullCheckBox.Checked;
                IsPrimaryKeyColumns[selectedIndex] = PrimaryKeyCheckBox.Checked;
                IsUniqueColumns[selectedIndex] = UniqueCheckBox.Checked;

                ColumnsListBox.Items[selectedIndex] = $"{ColumnNames[selectedIndex]} ({DataTypes[selectedIndex]}) {IsNotNullConstraints[selectedIndex]} {IsPrimaryKeyColumns[selectedIndex]} {IsUniqueColumns[selectedIndex]}";

                ClearInputFields();
            }
        }
        private void ClearInputFields()
        {
            ColumnNameTextBox.Clear();
            DataTypeComboBox.SelectedIndex = -1;
            UniqueCheckBox.Checked = false;
            NotNullCheckBox.Checked = false;
            PrimaryKeyCheckBox.Checked = false;
        }

        private void ColumnsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ColumnsListBox.SelectedItem != null)
            {
                int selectedIndex = ColumnsListBox.SelectedIndex;

                ColumnNameTextBox.Text = ColumnNames[selectedIndex];
                DataTypeComboBox.Text = DataTypes[selectedIndex];
                NotNullCheckBox.Checked = IsNotNullConstraints[selectedIndex];
                PrimaryKeyCheckBox.Checked = IsPrimaryKeyColumns[selectedIndex];
                UniqueCheckBox.Checked = IsUniqueColumns[selectedIndex];
            }
        }
    }
}
