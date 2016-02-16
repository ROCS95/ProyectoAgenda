namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.wbFace = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbFace
            // 
            this.wbFace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbFace.Location = new System.Drawing.Point(0, 0);
            this.wbFace.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbFace.Name = "wbFace";
            this.wbFace.Size = new System.Drawing.Size(594, 350);
            this.wbFace.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 350);
            this.Controls.Add(this.wbFace);
            this.Name = "Form1";
            this.Text = "Facebook Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbFace;
    }
}

