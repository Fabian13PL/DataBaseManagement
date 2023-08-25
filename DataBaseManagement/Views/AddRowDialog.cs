using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DataBaseManagement.Views
{
    public partial class AddRowDialog : Form
    {
        public List<string> RowValues { get; private set; }

        public AddRowDialog(List<string> columnNames)
        {
            InitializeComponent();
            this.ShowIcon = false;

            // Tworzymy TextBox dla każdej kolumny
            foreach (string columnName in columnNames)
            {
                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.AutoSize = true;

                Label label = new Label();
                label.Text = columnName + ":";
                label.AutoSize = true;

                TextBox textBox = new TextBox();
                textBox.Width = 200;

                panel.Controls.Add(label);
                panel.Controls.Add(textBox);

                flowLayoutPanel.Controls.Add(panel);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            RowValues = new List<string>();

            foreach (FlowLayoutPanel panel in flowLayoutPanel.Controls)
            {
                TextBox textBox = panel.Controls[1] as TextBox;
                if (textBox != null)
                {
                    RowValues.Add(textBox.Text);
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
