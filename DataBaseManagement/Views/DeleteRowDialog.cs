using System;
using System.Windows.Forms;

namespace DataBaseManagement.Views
{
    public partial class DeleteRowDialog : Form
    {
        public bool ConfirmDelete { get; private set; }
        public int SelectedRowID { get; private set; } // Przechowuje wybrany ID wiersza do usunięcia

        public DeleteRowDialog(Table table)
        {
            InitializeComponent();
            this.ShowIcon = false;

            using (DatabaseContext context = new DatabaseContext())
            {
                var rows = context.GetRows(table);

                comboBoxRowSelection.DataSource = rows;
                //comboBoxRowSelection.DisplayMember = "DisplayMember"; // Nazwa właściwości w obiekcie Row, która ma być wyświetlana
                //comboBoxRowSelection.ValueMember = "Id"; // Nazwa właściwości w obiekcie Row, która zawiera identyfikator wiersza
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            ConfirmDelete = true;
            SelectedRowID = (int)comboBoxRowSelection.SelectedValue; // Pobierz wybrany ID wiersza
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ConfirmDelete = false;
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
