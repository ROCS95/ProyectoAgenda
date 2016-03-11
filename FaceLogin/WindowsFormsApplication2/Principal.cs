using Facebook;
using Google;
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
        public Principal()
        {
            InitializeComponent();
        }
        public FacebookClient client;
  
        private void bttnFacebook_Click(object sender, EventArgs e)
        {
            FormFB fbd = new FormFB();
            switch (fbd.ShowDialog(this))
            {
                case DialogResult.Abort:
                    MessageBox.Show("There was an error or the user denied access!", "Error: An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case DialogResult.Cancel:  
                    MessageBox.Show("The user clicked cancel or closed the dialog!", "Error: Interupted by user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case DialogResult.OK:   
                    MessageBox.Show("User login was successfull!", "Successfull!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    client = new FacebookClient(fbd.access_token);
                    dynamic me = client.Get("me");
                    string name = me.name;
                    string mail = me.email;
                    string gender = me.gender;
                    Agenda ag = new Agenda(name,mail,gender,fbd.access_token);
                    ag.Show(this);
                    this.Hide();
                    break;
                default:
                    break;
            }
        }

        private void bttnGoogle_Click(object sender, EventArgs e)
        {
            Auth m = new Auth();
            var result = m.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                Agenda ag = new Agenda();
                ag.Show(this);
                this.Hide();
            }
        }

        private void buttonDB_Click(object sender, EventArgs e)
        {
            FormBD f = new FormBD();
            f.Show(this);
            this.Hide();
        }
    }
}
