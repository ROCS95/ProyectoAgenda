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
        string expiracion;
        public Principal()
        {
            InitializeComponent();
        }
       public FacebookClient client;
       public Google.GData.Client.GDataCredentials client2;
        private void bttnFacebook_Click(object sender, EventArgs e)
        {
            Form1 fbd = new Form1();
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
            //        ubo.DatosFacebook(me);

            //        public void DatosFacebook(dynamic datos) {
            //Usuario u = new Usuario()
            //{
               
            //    Name = datos.name




            //};

                        //}
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
                string access = m.access.Access_token;
                string refresh = m.access.refresh_token;
                if (DateTime.Now < m.access.created.AddHours(1))
                {
                    expiracion = m.access.created.AddHours(1).Subtract(DateTime.Now).Minutes.ToString();
                }
                Agenda ag = new Agenda(access, refresh, expiracion);
                ag.Show(this);
                this.Hide();
            }
        }
    }
}
