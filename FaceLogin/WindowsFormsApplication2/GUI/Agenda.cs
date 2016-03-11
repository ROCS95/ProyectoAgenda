using Facebook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.Entidades;

namespace WindowsFormsApplication2.GUI
{
    public partial class Agenda : Form
    {
        private string access_token;

        public FacebookClient client;
        private User us;

        public int DropUser { get; internal set; }
        public int FacebookUser { get; internal set; }
        public int GoogleUser { get; internal set; }

        public Agenda(User us, string access_token)
        {
            InitializeComponent();
            label2.Visible = true;
            button1.Visible = false;
            domainUpDown1.Visible = false;
            label4.Visible = false;
            textBox3.Visible = false;
            domainUpDown2.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            lblname.Text = us.Name;
            lblgender.Text = us.Gender;
            lblemail.Text = us.Email;
            this.access_token = access_token;
        }

        public Agenda()
        {
            InitializeComponent();
            label2.Visible = true;
            button1.Visible = false;
            domainUpDown1.Visible = false;
            label4.Visible = false;
            textBox3.Visible = false;
            domainUpDown2.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

        }

        public Agenda(User us)
        {
            this.us = us;
            InitializeComponent();
            label2.Visible = true;
            button1.Visible = false;
            domainUpDown1.Visible = false;
            label4.Visible = false;
            textBox3.Visible = false;
            domainUpDown2.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            lblname.Text = us.Name;
            lblemail.Text = us.Email;
        }

        private void pictBxMost_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            textBox2.Visible = true;
            label1.Visible = true;
            label4.Visible = true;
            textBox3.Visible = true;
            button1.Visible = true;
            btnAgreg.Visible = true;
            domainUpDown1.Visible = true;
            domainUpDown2.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label3.Text = DateTime.Now.ToString();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            textBox2.Visible = false;
            label1.Visible = false;
            btnAgreg.Visible = false;
            button1.Visible = false;
            domainUpDown1.Visible = false;
            textBox3.Visible = false;
            button1.Visible = false;
            label4.Visible = false;
            label3.Visible = false;
            domainUpDown2.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
        }

        private void btnAgreg_Click(object sender, EventArgs e)
        {
            string carpeta = lblname.Text;
            if (carpeta == "")
            {
                carpeta = "usuario";
            }
            try
            {
                if (!(Directory.Exists(carpeta)))
                {
                    Directory.CreateDirectory(carpeta);
                }
                if (Directory.Exists(carpeta))
                {
                    
                    if (domainUpDown1.SelectedIndex.ToString() != "-1" || domainUpDown2.SelectedIndex.ToString() != "-1")
                    {
                        if (textBox2.Text != "")
                        {
                            FileStream txt = new FileStream(carpeta + "//" + "Actividades.txt", FileMode.Append, FileAccess.Write);
                            StreamWriter writer = new StreamWriter(txt);
                            writer.WriteLine(textBox2.Text + " " + monthCalendar1.SelectionStart.ToString("dd-MMMM-yyyy") + " " + domainUpDown1.SelectedItem.ToString() + " " + domainUpDown2.SelectedItem.ToString());
                            MessageBox.Show("Actividad creada");
                            textBox2.Text = " ";
                            writer.Close();
                            txt.Close();
                        }
                        else
                        {
                            MessageBox.Show("Por favor escriba su descripción de la actividad");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor indique la hora");
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            string carpeta = lblname.Text;
            string txt = "";
            if (Directory.Exists(carpeta))
            {
                string[] lines = System.IO.File.ReadAllLines(carpeta + "/" + "Actividades.txt");
                foreach (string line in lines)
                {
                    string text = line;
                    string fecha = monthCalendar1.SelectionStart.ToString("dd-MMMM-yyyy"); ;
                    if (text.Contains(fecha))
                    {
                        txt += text + "\r\n";
                    }
                }
                textBox3.Text = txt;
            }

            textBox1.Text = monthCalendar1.SelectionStart.ToString("dd-MMMM-yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FacebookUser == 1)
            {
                Principal fbd = new Principal();
                var client = new FacebookClient(this.access_token);
                client.Post("/me/feed", new { message = "Proyecto Agenda" + textBox3.Text });
                MessageBox.Show("Actividad publicada con exito");
            }
            else
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
                        User us = new User();
                        us.Name = me.name;
                        us.Gender = me.gender;
                        us.Email = me.mail;
                        if (GoogleUser == 0 && DropUser == 0)
                        {
                            lblname.Text = us.Name;
                            lblgender.Text = us.Gender;
                            lblemail.Text = us.Email;
                        }
                        this.access_token = fbd.access_token;
                        FacebookUser = 1;
                        break;
                    default:
                        break;
                }
            }
        }

        private void Agenda_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DropUser == 0)
            {
                FormBD fdb = new FormBD()
                {
                    FaceUser = FacebookUser
                };
                fdb.Show(this);
                this.Hide();
            }
            else
            {
                this.Close();
            }

        }
    }
}
