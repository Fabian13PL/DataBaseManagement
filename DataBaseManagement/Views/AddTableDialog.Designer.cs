namespace DataBaseManagement.Views
{
    partial class AddTableDialog
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
            this.ColumnNameTextBox = new System.Windows.Forms.TextBox();
            this.DataTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ColumnsListBox = new System.Windows.Forms.ComboBox();
            this.TableNameTextBox = new System.Windows.Forms.TextBox();
            this.AddColumnButton = new System.Windows.Forms.Button();
            this.RemoveColumnButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.TableNameLabel = new System.Windows.Forms.Label();
            this.ColumnNameLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.ListOfColumnsLabel = new System.Windows.Forms.Label();
            this.NotNullCheckBox = new System.Windows.Forms.CheckBox();
            this.PrimaryKeyCheckBox = new System.Windows.Forms.CheckBox();
            this.UniqueCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ColumnNameTextBox
            // 
            this.ColumnNameTextBox.Location = new System.Drawing.Point(147, 41);
            this.ColumnNameTextBox.Name = "ColumnNameTextBox";
            this.ColumnNameTextBox.Size = new System.Drawing.Size(155, 22);
            this.ColumnNameTextBox.TabIndex = 0;
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
            this.DataTypeComboBox.Location = new System.Drawing.Point(147, 70);
            this.DataTypeComboBox.Name = "DataTypeComboBox";
            this.DataTypeComboBox.Size = new System.Drawing.Size(121, 24);
            this.DataTypeComboBox.TabIndex = 1;
            // 
            // ColumnsListBox
            // 
            this.ColumnsListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColumnsListBox.FormattingEnabled = true;
            this.ColumnsListBox.Location = new System.Drawing.Point(147, 100);
            this.ColumnsListBox.Name = "ColumnsListBox";
            this.ColumnsListBox.Size = new System.Drawing.Size(121, 24);
            this.ColumnsListBox.TabIndex = 2;
            // 
            // TableNameTextBox
            // 
            this.TableNameTextBox.Location = new System.Drawing.Point(147, 9);
            this.TableNameTextBox.Name = "TableNameTextBox";
            this.TableNameTextBox.Size = new System.Drawing.Size(155, 22);
            this.TableNameTextBox.TabIndex = 3;
            // 
            // AddColumnButton
            // 
            this.AddColumnButton.Location = new System.Drawing.Point(435, 41);
            this.AddColumnButton.Name = "AddColumnButton";
            this.AddColumnButton.Size = new System.Drawing.Size(131, 23);
            this.AddColumnButton.TabIndex = 4;
            this.AddColumnButton.Text = "Dodaj kolumnę";
            this.AddColumnButton.UseVisualStyleBackColor = true;
            this.AddColumnButton.Click += new System.EventHandler(this.AddColumnButton_Click);
            // 
            // RemoveColumnButton
            // 
            this.RemoveColumnButton.Location = new System.Drawing.Point(274, 100);
            this.RemoveColumnButton.Name = "RemoveColumnButton";
            this.RemoveColumnButton.Size = new System.Drawing.Size(109, 23);
            this.RemoveColumnButton.TabIndex = 5;
            this.RemoveColumnButton.Text = "Usuń kolumnę";
            this.RemoveColumnButton.UseVisualStyleBackColor = true;
            this.RemoveColumnButton.Click += new System.EventHandler(this.RemoveColumnButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(435, 70);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(131, 23);
            this.OKButton.TabIndex = 6;
            this.OKButton.Text = "Zaakceptuj zmiany";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(435, 101);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(131, 23);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Anuluj";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // TableNameLabel
            // 
            this.TableNameLabel.AutoSize = true;
            this.TableNameLabel.Location = new System.Drawing.Point(13, 12);
            this.TableNameLabel.Name = "TableNameLabel";
            this.TableNameLabel.Size = new System.Drawing.Size(84, 16);
            this.TableNameLabel.TabIndex = 8;
            this.TableNameLabel.Text = "Nazwa tabeli";
            // 
            // ColumnNameLabel
            // 
            this.ColumnNameLabel.AutoSize = true;
            this.ColumnNameLabel.Location = new System.Drawing.Point(13, 41);
            this.ColumnNameLabel.Name = "ColumnNameLabel";
            this.ColumnNameLabel.Size = new System.Drawing.Size(101, 16);
            this.ColumnNameLabel.TabIndex = 9;
            this.ColumnNameLabel.Text = "Nazwa kolumny";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(13, 70);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(84, 16);
            this.TypeLabel.TabIndex = 10;
            this.TypeLabel.Text = "Typ kolumny";
            // 
            // ListOfColumnsLabel
            // 
            this.ListOfColumnsLabel.AutoSize = true;
            this.ListOfColumnsLabel.Location = new System.Drawing.Point(13, 100);
            this.ListOfColumnsLabel.Name = "ListOfColumnsLabel";
            this.ListOfColumnsLabel.Size = new System.Drawing.Size(109, 16);
            this.ListOfColumnsLabel.TabIndex = 11;
            this.ListOfColumnsLabel.Text = "Dodane kolumny";
            // 
            // NotNullCheckBox
            // 
            this.NotNullCheckBox.AutoSize = true;
            this.NotNullCheckBox.Location = new System.Drawing.Point(309, 43);
            this.NotNullCheckBox.Name = "NotNullCheckBox";
            this.NotNullCheckBox.Size = new System.Drawing.Size(76, 20);
            this.NotNullCheckBox.TabIndex = 12;
            this.NotNullCheckBox.Text = "Not Null";
            this.NotNullCheckBox.UseVisualStyleBackColor = true;
            // 
            // PrimaryKeyCheckBox
            // 
            this.PrimaryKeyCheckBox.AutoSize = true;
            this.PrimaryKeyCheckBox.Location = new System.Drawing.Point(309, 70);
            this.PrimaryKeyCheckBox.Name = "PrimaryKeyCheckBox";
            this.PrimaryKeyCheckBox.Size = new System.Drawing.Size(101, 20);
            this.PrimaryKeyCheckBox.TabIndex = 13;
            this.PrimaryKeyCheckBox.Text = "Primary Key";
            this.PrimaryKeyCheckBox.UseVisualStyleBackColor = true;
            this.PrimaryKeyCheckBox.CheckedChanged += new System.EventHandler(this.PrimaryKeyCheckBox_CheckedChanged);
            // 
            // UniqueCheckBox
            // 
            this.UniqueCheckBox.AutoSize = true;
            this.UniqueCheckBox.Location = new System.Drawing.Point(309, 17);
            this.UniqueCheckBox.Name = "UniqueCheckBox";
            this.UniqueCheckBox.Size = new System.Drawing.Size(72, 20);
            this.UniqueCheckBox.TabIndex = 14;
            this.UniqueCheckBox.Text = "Unique";
            this.UniqueCheckBox.UseVisualStyleBackColor = true;
            this.UniqueCheckBox.CheckedChanged += new System.EventHandler(this.UniqueCheckBox_CheckedChanged);
            // 
            // AddTableDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 141);
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
            this.Name = "AddTableDialog";
            this.Text = "AddTableDialog";
            this.Load += new System.EventHandler(this.AddTableDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ColumnNameTextBox;
        private System.Windows.Forms.ComboBox DataTypeComboBox;
        private System.Windows.Forms.ComboBox ColumnsListBox;
        private System.Windows.Forms.TextBox TableNameTextBox;
        private System.Windows.Forms.Button AddColumnButton;
        private System.Windows.Forms.Button RemoveColumnButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label TableNameLabel;
        private System.Windows.Forms.Label ColumnNameLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label ListOfColumnsLabel;
        private System.Windows.Forms.CheckBox NotNullCheckBox;
        private System.Windows.Forms.CheckBox PrimaryKeyCheckBox;
        private System.Windows.Forms.CheckBox UniqueCheckBox;
    }
}