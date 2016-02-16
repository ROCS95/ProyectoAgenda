using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Facebook;
using Facebook.Winforms.Components;

namespace WindowsFormsApplication2
{
    public partial class Logueado : Form
    {
        

        public Logueado()
        {
            InitializeComponent();


        }

        private void Logueado_Load(object sender, EventArgs e)
        {

            
        }

        private void btnloguear_Click(object sender, EventArgs e)
        {
            Form1 fbd = new Form1();

            switch (fbd.ShowDialog(this))
            {
                case DialogResult.Abort:    // There was an error
                    // Get the error information
                    MessageBox.Show("There was an error or the user denied access! See log window for more information!", "Error: An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case DialogResult.Cancel:   // User clicked cancel or closed the dialog
                    MessageBox.Show("The user clicked cancel or closed the dialog!", "Error: Interupted by user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case DialogResult.OK:   // Logon successfull
                    MessageBox.Show("User login was successfull! See log window for more information!", "Successfull!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var client = new FacebookClient(fbd.access_token);
                    dynamic me = client.Get("me");
                    string name = me.name;
                    string mail = me.email;
                    string gender = me.gender;
                   // Image pic = me.picture;
                    lblname.Text = name;
                    lblgender.Text = gender;
                    lblemail.Text = mail;
                   // pictureBox1.Image = pic;
                    break;
                default:
                    break;
            }
        }
    }
}
