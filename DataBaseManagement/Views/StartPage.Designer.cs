﻿namespace DataBaseManagement.Views
{
    partial class StartPage
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
            this.ButtonAddDataBase = new System.Windows.Forms.Button();
            this.DataBaseList = new System.Windows.Forms.ComboBox();
            this.ButtonSelectDataBase = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonAddDataBase
            // 
            this.ButtonAddDataBase.Location = new System.Drawing.Point(93, 42);
            this.ButtonAddDataBase.Name = "ButtonAddDataBase";
            this.ButtonAddDataBase.Size = new System.Drawing.Size(135, 23);
            this.ButtonAddDataBase.TabIndex = 0;
            this.ButtonAddDataBase.Text = "Stwórz bazę danych";
            this.ButtonAddDataBase.UseVisualStyleBackColor = true;
            this.ButtonAddDataBase.Click += new System.EventHandler(this.AddDataBase_Click);
            // 
            // DataBaseList
            // 
            this.DataBaseList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataBaseList.FormattingEnabled = true;
            this.DataBaseList.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DataBaseList.Location = new System.Drawing.Point(12, 12);
            this.DataBaseList.Name = "DataBaseList";
            this.DataBaseList.Size = new System.Drawing.Size(328, 24);
            this.DataBaseList.TabIndex = 1;
            this.DataBaseList.SelectedIndexChanged += new System.EventHandler(this.DataBaseList_SelectedIndexChanged);
            this.DataBaseList.SelectedValueChanged += new System.EventHandler(this.DataBaseList_SelectedValueChanged);
            this.DataBaseList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataBaseList_MouseClick);
            // 
            // ButtonSelectDataBase
            // 
            this.ButtonSelectDataBase.Location = new System.Drawing.Point(234, 42);
            this.ButtonSelectDataBase.Name = "ButtonSelectDataBase";
            this.ButtonSelectDataBase.Size = new System.Drawing.Size(106, 23);
            this.ButtonSelectDataBase.TabIndex = 2;
            this.ButtonSelectDataBase.Text = "Wybierz bazę danych";
            this.ButtonSelectDataBase.UseVisualStyleBackColor = true;
            this.ButtonSelectDataBase.Click += new System.EventHandler(this.ButtonSelectDataBase_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(12, 42);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(75, 23);
            this.ButtonExit.TabIndex = 3;
            this.ButtonExit.Text = "Zamknij";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 79);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonSelectDataBase);
            this.Controls.Add(this.DataBaseList);
            this.Controls.Add(this.ButtonAddDataBase);
            this.Name = "StartPage";
            this.Text = "Wybierz bazę danych";
            this.Load += new System.EventHandler(this.StartPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddDataBase;
        private System.Windows.Forms.ComboBox DataBaseList;
        private System.Windows.Forms.Button ButtonSelectDataBase;
        private System.Windows.Forms.Button ButtonExit;
    }
}