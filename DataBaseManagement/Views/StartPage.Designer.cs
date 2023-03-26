namespace DataBaseManagement.Views
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
            this.SuspendLayout();
            // 
            // ButtonAddDataBase
            // 
            this.ButtonAddDataBase.Location = new System.Drawing.Point(462, 55);
            this.ButtonAddDataBase.Name = "ButtonAddDataBase";
            this.ButtonAddDataBase.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddDataBase.TabIndex = 0;
            this.ButtonAddDataBase.Text = "button1";
            this.ButtonAddDataBase.UseVisualStyleBackColor = true;
            this.ButtonAddDataBase.Click += new System.EventHandler(this.AddDataBase_Click);
            // 
            // DataBaseList
            // 
            this.DataBaseList.FormattingEnabled = true;
            this.DataBaseList.Location = new System.Drawing.Point(73, 55);
            this.DataBaseList.Name = "DataBaseList";
            this.DataBaseList.Size = new System.Drawing.Size(329, 24);
            this.DataBaseList.TabIndex = 1;
            this.DataBaseList.SelectedIndexChanged += new System.EventHandler(this.DataBaseList_SelectedIndexChanged);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 179);
            this.Controls.Add(this.DataBaseList);
            this.Controls.Add(this.ButtonAddDataBase);
            this.Name = "StartPage";
            this.Text = "StartPage";
            this.Load += new System.EventHandler(this.StartPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddDataBase;
        private System.Windows.Forms.ComboBox DataBaseList;
    }
}