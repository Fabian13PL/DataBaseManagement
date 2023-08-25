namespace DataBaseManagement.Views
{
    partial class AddDataBase
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonCreateDatabase = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.DatabaseNameLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(15, 28);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(379, 22);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(15, 81);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(379, 210);
            this.textBoxDescription.TabIndex = 2;
            // 
            // buttonCreateDatabase
            // 
            this.buttonCreateDatabase.Location = new System.Drawing.Point(319, 297);
            this.buttonCreateDatabase.Name = "buttonCreateDatabase";
            this.buttonCreateDatabase.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateDatabase.TabIndex = 3;
            this.buttonCreateDatabase.Text = "Utwórz";
            this.buttonCreateDatabase.UseVisualStyleBackColor = true;
            this.buttonCreateDatabase.Click += new System.EventHandler(this.buttonCreateDatabase_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(238, 297);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // DatabaseNameLabel
            // 
            this.DatabaseNameLabel.AutoSize = true;
            this.DatabaseNameLabel.Location = new System.Drawing.Point(12, 9);
            this.DatabaseNameLabel.Name = "DatabaseNameLabel";
            this.DatabaseNameLabel.Size = new System.Drawing.Size(127, 16);
            this.DatabaseNameLabel.TabIndex = 5;
            this.DatabaseNameLabel.Text = "Nazwa bazy danych";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 62);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(35, 16);
            this.DescriptionLabel.TabIndex = 7;
            this.DescriptionLabel.Text = "Opis";
            // 
            // AddDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 325);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.DatabaseNameLabel);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCreateDatabase);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxName);
            this.Name = "AddDataBase";
            this.Text = "Dodaj bazę danych";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonCreateDatabase;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label DatabaseNameLabel;
        private System.Windows.Forms.Label DescriptionLabel;
    }
}