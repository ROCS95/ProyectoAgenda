namespace WindowsFormsApplication2
{
    partial class Agenda
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgreg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDown = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictBxMost = new System.Windows.Forms.PictureBox();
            this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBxMost)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(421, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "BIENVENIDO";
            this.label2.Visible = false;
            // 
            // btnAgreg
            // 
            this.btnAgreg.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgreg.Location = new System.Drawing.Point(557, 323);
            this.btnAgreg.Name = "btnAgreg";
            this.btnAgreg.Size = new System.Drawing.Size(82, 22);
            this.btnAgreg.TabIndex = 15;
            this.btnAgreg.Text = "Agregar";
            this.btnAgreg.UseVisualStyleBackColor = true;
            this.btnAgreg.Visible = false;
            this.btnAgreg.Click += new System.EventHandler(this.btnAgreg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "Agregar actividad";
            this.label1.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(355, 128);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(284, 169);
            this.textBox2.TabIndex = 13;
            this.textBox2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 92);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 30);
            this.textBox1.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDown);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.Location = new System.Drawing.Point(35, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 217);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // btnDown
            // 
            this.btnDown.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDown.Location = new System.Drawing.Point(207, 194);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 1;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.DarkGray;
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(12, 25);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(250, 9);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(45, 18);
            this.lblgender.TabIndex = 21;
            this.lblgender.Text = "label3";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(12, 9);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(45, 18);
            this.lblname.TabIndex = 20;
            this.lblname.Text = "label2";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(139, 9);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(45, 18);
            this.lblemail.TabIndex = 19;
            this.lblemail.Text = "label1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(765, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Publicar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainUpDown1.Items.Add("1 AM");
            this.domainUpDown1.Items.Add("2 AM");
            this.domainUpDown1.Items.Add("3 AM");
            this.domainUpDown1.Items.Add("4 AM");
            this.domainUpDown1.Items.Add("5 AM");
            this.domainUpDown1.Items.Add("6 AM");
            this.domainUpDown1.Items.Add("7 AM");
            this.domainUpDown1.Items.Add("8 AM");
            this.domainUpDown1.Items.Add("9 AM");
            this.domainUpDown1.Items.Add("10 AM");
            this.domainUpDown1.Items.Add("11 AM");
            this.domainUpDown1.Items.Add("12 PM");
            this.domainUpDown1.Items.Add("1 PM");
            this.domainUpDown1.Items.Add("2 PM");
            this.domainUpDown1.Items.Add("3 PM");
            this.domainUpDown1.Items.Add("4 PM");
            this.domainUpDown1.Items.Add("5 PM");
            this.domainUpDown1.Items.Add("6 PM");
            this.domainUpDown1.Items.Add("7 PM");
            this.domainUpDown1.Items.Add("8 PM");
            this.domainUpDown1.Items.Add("9 PM");
            this.domainUpDown1.Items.Add("10 PM");
            this.domainUpDown1.Items.Add("11 PM");
            this.domainUpDown1.Items.Add("12 AM");
            this.domainUpDown1.Location = new System.Drawing.Point(461, 327);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(68, 20);
            this.domainUpDown1.TabIndex = 23;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(658, 128);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(284, 169);
            this.textBox3.TabIndex = 24;
            this.textBox3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(726, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 22);
            this.label4.TabIndex = 25;
            this.label4.Text = "Actividades pendientes";
            this.label4.Visible = false;
            // 
            // pictBxMost
            // 
            this.pictBxMost.Image = global::WindowsFormsApplication2.Properties.Resources.calendario;
            this.pictBxMost.Location = new System.Drawing.Point(282, 92);
            this.pictBxMost.Name = "pictBxMost";
            this.pictBxMost.Size = new System.Drawing.Size(35, 30);
            this.pictBxMost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBxMost.TabIndex = 11;
            this.pictBxMost.TabStop = false;
            this.pictBxMost.Click += new System.EventHandler(this.pictBxMost_Click);
            // 
            // domainUpDown2
            // 
            this.domainUpDown2.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainUpDown2.Items.Add("1 AM");
            this.domainUpDown2.Items.Add("2 AM");
            this.domainUpDown2.Items.Add("3 AM");
            this.domainUpDown2.Items.Add("4 AM");
            this.domainUpDown2.Items.Add("5 AM");
            this.domainUpDown2.Items.Add("6 AM");
            this.domainUpDown2.Items.Add("7 AM");
            this.domainUpDown2.Items.Add("8 AM");
            this.domainUpDown2.Items.Add("9 AM");
            this.domainUpDown2.Items.Add("10 AM");
            this.domainUpDown2.Items.Add("11 AM");
            this.domainUpDown2.Items.Add("12 PM");
            this.domainUpDown2.Items.Add("1 PM");
            this.domainUpDown2.Items.Add("2 PM");
            this.domainUpDown2.Items.Add("3 PM");
            this.domainUpDown2.Items.Add("4 PM");
            this.domainUpDown2.Items.Add("5 PM");
            this.domainUpDown2.Items.Add("6 PM");
            this.domainUpDown2.Items.Add("7 PM");
            this.domainUpDown2.Items.Add("8 PM");
            this.domainUpDown2.Items.Add("9 PM");
            this.domainUpDown2.Items.Add("10 PM");
            this.domainUpDown2.Items.Add("11 PM");
            this.domainUpDown2.Items.Add("12 AM");
            this.domainUpDown2.Location = new System.Drawing.Point(461, 364);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.Size = new System.Drawing.Size(68, 20);
            this.domainUpDown2.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(357, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "Hora de inicio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(357, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 28;
            this.label6.Text = "Hora de fin:";
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(988, 426);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.domainUpDown2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgreg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictBxMost);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Agenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Agenda_FormClosed);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictBxMost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgreg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictBxMost;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DomainUpDown domainUpDown2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}