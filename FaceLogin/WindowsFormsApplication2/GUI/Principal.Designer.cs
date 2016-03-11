namespace WindowsFormsApplication2.GUI
{
    partial class Principal
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
            this.bttnFacebook = new System.Windows.Forms.Button();
            this.bttnGoogle = new System.Windows.Forms.Button();
            this.buttonDB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttnFacebook
            // 
            this.bttnFacebook.Image = global::WindowsFormsApplication2.Properties.Resources.Facebook;
            this.bttnFacebook.Location = new System.Drawing.Point(106, 152);
            this.bttnFacebook.Name = "bttnFacebook";
            this.bttnFacebook.Size = new System.Drawing.Size(273, 39);
            this.bttnFacebook.TabIndex = 0;
            this.bttnFacebook.UseVisualStyleBackColor = true;
            this.bttnFacebook.Click += new System.EventHandler(this.bttnFacebook_Click);
            // 
            // bttnGoogle
            // 
            this.bttnGoogle.Image = global::WindowsFormsApplication2.Properties.Resources.Google;
            this.bttnGoogle.Location = new System.Drawing.Point(154, 32);
            this.bttnGoogle.Name = "bttnGoogle";
            this.bttnGoogle.Size = new System.Drawing.Size(189, 39);
            this.bttnGoogle.TabIndex = 1;
            this.bttnGoogle.UseVisualStyleBackColor = true;
            this.bttnGoogle.Click += new System.EventHandler(this.bttnGoogle_Click);
            // 
            // buttonDB
            // 
            this.buttonDB.Image = global::WindowsFormsApplication2.Properties.Resources.dropbox;
            this.buttonDB.Location = new System.Drawing.Point(140, 93);
            this.buttonDB.Name = "buttonDB";
            this.buttonDB.Size = new System.Drawing.Size(213, 35);
            this.buttonDB.TabIndex = 2;
            this.buttonDB.UseVisualStyleBackColor = true;
            this.buttonDB.Click += new System.EventHandler(this.buttonDB_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.fondoPrin;
            this.ClientSize = new System.Drawing.Size(495, 226);
            this.Controls.Add(this.buttonDB);
            this.Controls.Add(this.bttnGoogle);
            this.Controls.Add(this.bttnFacebook);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttnGoogle;
        private System.Windows.Forms.Button bttnFacebook;
        private System.Windows.Forms.Button buttonDB;
    }
}