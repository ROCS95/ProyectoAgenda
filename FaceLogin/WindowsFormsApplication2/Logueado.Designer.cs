namespace WindowsFormsApplication2
{
    partial class Logueado
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
            this.lblemail = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.btnloguear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mensaje = new System.Windows.Forms.TextBox();
            this.btnpub = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(227, 84);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(35, 13);
            this.lblemail.TabIndex = 1;
            this.lblemail.Text = "label1";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(227, 124);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(35, 13);
            this.lblname.TabIndex = 2;
            this.lblname.Text = "label2";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(227, 175);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(35, 13);
            this.lblgender.TabIndex = 3;
            this.lblgender.Text = "label3";
            // 
            // btnloguear
            // 
            this.btnloguear.Location = new System.Drawing.Point(206, 289);
            this.btnloguear.Name = "btnloguear";
            this.btnloguear.Size = new System.Drawing.Size(75, 23);
            this.btnloguear.TabIndex = 4;
            this.btnloguear.Text = "Login";
            this.btnloguear.UseVisualStyleBackColor = true;
            this.btnloguear.Click += new System.EventHandler(this.btnloguear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(38, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 123);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // mensaje
            // 
            this.mensaje.Location = new System.Drawing.Point(303, 191);
            this.mensaje.Multiline = true;
            this.mensaje.Name = "mensaje";
            this.mensaje.Size = new System.Drawing.Size(203, 73);
            this.mensaje.TabIndex = 6;
            // 
            // btnpub
            // 
            this.btnpub.Location = new System.Drawing.Point(361, 288);
            this.btnpub.Name = "btnpub";
            this.btnpub.Size = new System.Drawing.Size(75, 23);
            this.btnpub.TabIndex = 7;
            this.btnpub.Text = "publicar";
            this.btnpub.UseVisualStyleBackColor = true;
            this.btnpub.Click += new System.EventHandler(this.btnpub_Click);
            // 
            // Logueado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 413);
            this.Controls.Add(this.btnpub);
            this.Controls.Add(this.mensaje);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnloguear);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblemail);
            this.Name = "Logueado";
            this.Text = "Logueado";
            this.Load += new System.EventHandler(this.Logueado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Button btnloguear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox mensaje;
        private System.Windows.Forms.Button btnpub;
    }
}