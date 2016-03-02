﻿using Facebook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Principal : Form
    {
        string expiracion;
        public Principal()
        {
            InitializeComponent();
        }
       public FacebookClient client;
        private void bttnFacebook_Click(object sender, EventArgs e)
        {
            Form1 fbd = new Form1();
            switch (fbd.ShowDialog(this))
            {
                case DialogResult.Abort:    // There was an error
                    // Get the error information
                    MessageBox.Show("There was an error or the user denied access!", "Error: An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case DialogResult.Cancel:   // User clicked cancel or closed the dialog
                    MessageBox.Show("The user clicked cancel or closed the dialog!", "Error: Interupted by user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case DialogResult.OK:   // Logon successfull
                    MessageBox.Show("User login was successfull!", "Successfull!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    client = new FacebookClient(fbd.access_token);
                    dynamic me = client.Get("me");
                    string name = me.name;
                    string mail = me.email;
                    string gender = me.gender;
                    Agenda ag = new Agenda(name,mail,gender,fbd.access_token);
                    ag.Show(this);
                    this.Hide();
                    
                    // Image pic = me.picture;
                    // pictureBox1.Image = pic;
                    break;
                default:
                    break;
            }
        }

        private void bttnGoogle_Click(object sender, EventArgs e)
        {
            Auth m = new Auth();
            var result = m.ShowDialog();
            if (result == DialogResult.OK)
            {
                string access = m.access.Access_token;
                string refresh = m.access.refresh_token;
               
               
                //AccessToken.Text = m.access.Access_token;
                //refreshToken.Text = m.access.refresh_token;

                if (DateTime.Now < m.access.created.AddHours(1))
                {
                    expiracion = m.access.created.AddHours(1).Subtract(DateTime.Now).Minutes.ToString();
                    // Expire.Text = m.access.created.AddHours(1).Subtract(DateTime.Now).Minutes.ToString();
                }
                Agenda ag = new Agenda(access, refresh, expiracion);
                ag.Show();
                m.Hide();
            }
        }
    }
}
