namespace DataBaseManagement.Views
{
    partial class ManageTablesDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxTableNames = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.SelectActionButton = new System.Windows.Forms.Button();
            this.SelectActionComboBox = new System.Windows.Forms.ComboBox();
            this.SelectTableLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTableNames
            // 
            this.comboBoxTableNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTableNames.FormattingEnabled = true;
            this.comboBoxTableNames.Location = new System.Drawing.Point(115, 12);
            this.comboBoxTableNames.Name = "comboBoxTableNames";
            this.comboBoxTableNames.Size = new System.Drawing.Size(185, 24);
            this.comboBoxTableNames.TabIndex = 0;
            this.comboBoxTableNames.SelectedIndexChanged += new System.EventHandler(this.comboBoxTableNames_SelectedIndexChanged);
            this.comboBoxTableNames.SelectedValueChanged += new System.EventHandler(this.comboBoxTableNames_SelectedValueChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 65);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1058, 470);
            this.dataGridView.TabIndex = 1;
            // 
            // SelectActionButton
            // 
            this.SelectActionButton.Location = new System.Drawing.Point(957, 8);
            this.SelectActionButton.Name = "SelectActionButton";
            this.SelectActionButton.Size = new System.Drawing.Size(113, 30);
            this.SelectActionButton.TabIndex = 2;
            this.SelectActionButton.Text = "Wybierz akcję";
            this.SelectActionButton.UseVisualStyleBackColor = true;
            this.SelectActionButton.Click += new System.EventHandler(this.SelectActionButton_Click);
            // 
            // SelectActionComboBox
            // 
            this.SelectActionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectActionComboBox.FormattingEnabled = true;
            this.SelectActionComboBox.Items.AddRange(new object[] {
            "Dodaj nową tabelę",
            "Usuń wybraną tabelę",
            "Edytuj kolumny",
            "Dodaj wiersz",
            "Usuń wiersz",
            "Eksportuj tabelę do CSV"});
            this.SelectActionComboBox.Location = new System.Drawing.Point(688, 12);
            this.SelectActionComboBox.Name = "SelectActionComboBox";
            this.SelectActionComboBox.Size = new System.Drawing.Size(263, 24);
            this.SelectActionComboBox.TabIndex = 3;
            // 
            // SelectTableLabel
            // 
            this.SelectTableLabel.AutoSize = true;
            this.SelectTableLabel.Location = new System.Drawing.Point(12, 20);
            this.SelectTableLabel.Name = "SelectTableLabel";
            this.SelectTableLabel.Size = new System.Drawing.Size(97, 16);
            this.SelectTableLabel.TabIndex = 4;
            this.SelectTableLabel.Text = "Wybierz tabelę";
            // 
            // ManageTablesDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 547);
            this.Controls.Add(this.SelectTableLabel);
            this.Controls.Add(this.SelectActionComboBox);
            this.Controls.Add(this.SelectActionButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.comboBoxTableNames);
            this.Name = "ManageTablesDialog";
            this.Text = "ManageTablesDialog";
            this.Load += new System.EventHandler(this.ManageTablesDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTableNames;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button SelectActionButton;
        private System.Windows.Forms.ComboBox SelectActionComboBox;
        private System.Windows.Forms.Label SelectTableLabel;
    }
}