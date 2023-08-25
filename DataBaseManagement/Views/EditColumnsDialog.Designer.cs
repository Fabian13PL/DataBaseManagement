namespace DataBaseManagement.Views
{
    partial class EditColumnsDialog
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
            this.UniqueCheckBox = new System.Windows.Forms.CheckBox();
            this.PrimaryKeyCheckBox = new System.Windows.Forms.CheckBox();
            this.NotNullCheckBox = new System.Windows.Forms.CheckBox();
            this.ListOfColumnsLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.ColumnNameLabel = new System.Windows.Forms.Label();
            this.TableNameLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.RemoveColumnButton = new System.Windows.Forms.Button();
            this.AddColumnButton = new System.Windows.Forms.Button();
            this.TableNameTextBox = new System.Windows.Forms.TextBox();
            this.ColumnsListBox = new System.Windows.Forms.ComboBox();
            this.DataTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ColumnNameTextBox = new System.Windows.Forms.TextBox();
            this.EditColumnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UniqueCheckBox
            // 
            this.UniqueCheckBox.AutoSize = true;
            this.UniqueCheckBox.Location = new System.Drawing.Point(308, 20);
            this.UniqueCheckBox.Name = "UniqueCheckBox";
            this.UniqueCheckBox.Size = new System.Drawing.Size(72, 20);
            this.UniqueCheckBox.TabIndex = 29;
            this.UniqueCheckBox.Text = "Unique";
            this.UniqueCheckBox.UseVisualStyleBackColor = true;
            this.UniqueCheckBox.CheckedChanged += new System.EventHandler(this.UniqueCheckBox_CheckedChanged);
            // 
            // PrimaryKeyCheckBox
            // 
            this.PrimaryKeyCheckBox.AutoSize = true;
            this.PrimaryKeyCheckBox.Location = new System.Drawing.Point(308, 73);
            this.PrimaryKeyCheckBox.Name = "PrimaryKeyCheckBox";
            this.PrimaryKeyCheckBox.Size = new System.Drawing.Size(101, 20);
            this.PrimaryKeyCheckBox.TabIndex = 28;
            this.PrimaryKeyCheckBox.Text = "Primary Key";
            this.PrimaryKeyCheckBox.UseVisualStyleBackColor = true;
            this.PrimaryKeyCheckBox.CheckedChanged += new System.EventHandler(this.PrimaryKeyCheckBox_CheckedChanged);
            // 
            // NotNullCheckBox
            // 
            this.NotNullCheckBox.AutoSize = true;
            this.NotNullCheckBox.Location = new System.Drawing.Point(308, 46);
            this.NotNullCheckBox.Name = "NotNullCheckBox";
            this.NotNullCheckBox.Size = new System.Drawing.Size(76, 20);
            this.NotNullCheckBox.TabIndex = 27;
            this.NotNullCheckBox.Text = "Not Null";
            this.NotNullCheckBox.UseVisualStyleBackColor = true;
            // 
            // ListOfColumnsLabel
            // 
            this.ListOfColumnsLabel.AutoSize = true;
            this.ListOfColumnsLabel.Location = new System.Drawing.Point(12, 103);
            this.ListOfColumnsLabel.Name = "ListOfColumnsLabel";
            this.ListOfColumnsLabel.Size = new System.Drawing.Size(109, 16);
            this.ListOfColumnsLabel.TabIndex = 26;
            this.ListOfColumnsLabel.Text = "Dodane kolumny";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(12, 73);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(84, 16);
            this.TypeLabel.TabIndex = 25;
            this.TypeLabel.Text = "Typ kolumny";
            // 
            // ColumnNameLabel
            // 
            this.ColumnNameLabel.AutoSize = true;
            this.ColumnNameLabel.Location = new System.Drawing.Point(12, 44);
            this.ColumnNameLabel.Name = "ColumnNameLabel";
            this.ColumnNameLabel.Size = new System.Drawing.Size(101, 16);
            this.ColumnNameLabel.TabIndex = 24;
            this.ColumnNameLabel.Text = "Nazwa kolumny";
            // 
            // TableNameLabel
            // 
            this.TableNameLabel.AutoSize = true;
            this.TableNameLabel.Location = new System.Drawing.Point(12, 15);
            this.TableNameLabel.Name = "TableNameLabel";
            this.TableNameLabel.Size = new System.Drawing.Size(84, 16);
            this.TableNameLabel.TabIndex = 23;
            this.TableNameLabel.Text = "Nazwa tabeli";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(434, 104);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(131, 23);
            this.CancelButton.TabIndex = 22;
            this.CancelButton.Text = "Anuluj";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(434, 73);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(131, 23);
            this.OKButton.TabIndex = 21;
            this.OKButton.Text = "Zaakceptuj zmiany";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // RemoveColumnButton
            // 
            this.RemoveColumnButton.Location = new System.Drawing.Point(273, 103);
            this.RemoveColumnButton.Name = "RemoveColumnButton";
            this.RemoveColumnButton.Size = new System.Drawing.Size(109, 23);
            this.RemoveColumnButton.TabIndex = 20;
            this.RemoveColumnButton.Text = "Usuń kolumnę";
            this.RemoveColumnButton.UseVisualStyleBackColor = true;
            this.RemoveColumnButton.Click += new System.EventHandler(this.RemoveColumnButton_Click);
            // 
            // AddColumnButton
            // 
            this.AddColumnButton.Location = new System.Drawing.Point(434, 44);
            this.AddColumnButton.Name = "AddColumnButton";
            this.AddColumnButton.Size = new System.Drawing.Size(131, 23);
            this.AddColumnButton.TabIndex = 19;
            this.AddColumnButton.Text = "Dodaj kolumnę";
            this.AddColumnButton.UseVisualStyleBackColor = true;
            this.AddColumnButton.Click += new System.EventHandler(this.AddColumnButton_Click);
            // 
            // TableNameTextBox
            // 
            this.TableNameTextBox.Enabled = false;
            this.TableNameTextBox.Location = new System.Drawing.Point(146, 12);
            this.TableNameTextBox.Name = "TableNameTextBox";
            this.TableNameTextBox.Size = new System.Drawing.Size(155, 22);
            this.TableNameTextBox.TabIndex = 18;
            // 
            // ColumnsListBox
            // 
            this.ColumnsListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColumnsListBox.FormattingEnabled = true;
            this.ColumnsListBox.Location = new System.Drawing.Point(146, 103);
            this.ColumnsListBox.Name = "ColumnsListBox";
            this.ColumnsListBox.Size = new System.Drawing.Size(121, 24);
            this.ColumnsListBox.TabIndex = 17;
            this.ColumnsListBox.SelectedIndexChanged += new System.EventHandler(this.ColumnsListBox_SelectedIndexChanged);
            // 
            // DataTypeComboBox
            // 
            this.DataTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataTypeComboBox.FormattingEnabled = true;
            this.DataTypeComboBox.Items.AddRange(new object[] {
            "BINARY",
            "BIT",
            "BIGINT",
            "CHAR",
            "CURSOR",
            "DATE",
            "DATETIME",
            "DATETIME2",
            "DECIMAL",
            "FLOAT",
            "GEOGRAPHY",
            "GEOMETRY",
            "HIERARCHYID",
            "IMAGE",
            "INT",
            "MONEY",
            "NCHAR",
            "NTEXT",
            "NVARCHAR",
            "REAL",
            "SMALLDATETIME",
            "SMALLINT",
            "SMALLMONEY",
            "SQL_VARIANT",
            "TABLE",
            "TEXT",
            "TIME",
            "TIMESTAMP",
            "TINYINT",
            "UNION",
            "UNIQUEIDENTIFIER",
            "VARBINARY",
            "VARCHAR",
            "XML"});
            this.DataTypeComboBox.Location = new System.Drawing.Point(146, 73);
            this.DataTypeComboBox.Name = "DataTypeComboBox";
            this.DataTypeComboBox.Size = new System.Drawing.Size(121, 24);
            this.DataTypeComboBox.TabIndex = 16;
            // 
            // ColumnNameTextBox
            // 
            this.ColumnNameTextBox.Location = new System.Drawing.Point(146, 44);
            this.ColumnNameTextBox.Name = "ColumnNameTextBox";
            this.ColumnNameTextBox.Size = new System.Drawing.Size(155, 22);
            this.ColumnNameTextBox.TabIndex = 15;
            // 
            // EditColumnButton
            // 
            this.EditColumnButton.Location = new System.Drawing.Point(434, 15);
            this.EditColumnButton.Name = "EditColumnButton";
            this.EditColumnButton.Size = new System.Drawing.Size(131, 23);
            this.EditColumnButton.TabIndex = 30;
            this.EditColumnButton.Text = "Edytuj kolumnę";
            this.EditColumnButton.UseVisualStyleBackColor = true;
            this.EditColumnButton.Click += new System.EventHandler(this.EditColumnButton_Click);
            // 
            // EditColumnsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 144);
            this.Controls.Add(this.EditColumnButton);
            this.Controls.Add(this.UniqueCheckBox);
            this.Controls.Add(this.PrimaryKeyCheckBox);
            this.Controls.Add(this.NotNullCheckBox);
            this.Controls.Add(this.ListOfColumnsLabel);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.ColumnNameLabel);
            this.Controls.Add(this.TableNameLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.RemoveColumnButton);
            this.Controls.Add(this.AddColumnButton);
            this.Controls.Add(this.TableNameTextBox);
            this.Controls.Add(this.ColumnsListBox);
            this.Controls.Add(this.DataTypeComboBox);
            this.Controls.Add(this.ColumnNameTextBox);
            this.Name = "EditColumnsDialog";
            this.Text = "EditColumnsDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox UniqueCheckBox;
        private System.Windows.Forms.CheckBox PrimaryKeyCheckBox;
        private System.Windows.Forms.CheckBox NotNullCheckBox;
        private System.Windows.Forms.Label ListOfColumnsLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label ColumnNameLabel;
        private System.Windows.Forms.Label TableNameLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button RemoveColumnButton;
        private System.Windows.Forms.Button AddColumnButton;
        private System.Windows.Forms.TextBox TableNameTextBox;
        private System.Windows.Forms.ComboBox ColumnsListBox;
        private System.Windows.Forms.ComboBox DataTypeComboBox;
        private System.Windows.Forms.TextBox ColumnNameTextBox;
        private System.Windows.Forms.Button EditColumnButton;
    }
}