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

namespace WindowsFormsApplication2
{
    public partial class Agenda : Form
    {
        private string access_token;
        private string access;
        private string refresh;
        private string expiracion;

        public Agenda(string name, string gender, string mail, string access_token)
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
            lblname.Text = name;
            lblgender.Text = gender;
            lblemail.Text = mail;
            this.access_token = access_token;
        }

        public Agenda(string name, string access, string expiracion)
        {
         
            this.access = access;
        //    this.refresh = refresh;
            this.expiracion = expiracion;
            InitializeComponent();
            label2.Visible = true;
            button1.Visible = false;
            domainUpDown1.Visible = false;
            label4.Visible = false;
            textBox3.Visible = false;
            domainUpDown2.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            lblname.Text = name;
           // lblgender.Text = refresh;
          // lblemail.Text = expiracion;
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
            try
            {
                if (!(Directory.Exists(carpeta)))
                {
                    Directory.CreateDirectory(carpeta);
                }
                if (Directory.Exists(carpeta))
                {
                    FileStream txt = new FileStream(carpeta+"/"+"Actividades.txt", FileMode.Append, FileAccess.Write);
                    StreamWriter writer = new StreamWriter(txt);
                    writer.WriteLine(textBox2.Text + " " + monthCalendar1.SelectionStart.ToString("dd-MMMM-yyyy") + " " + domainUpDown1.SelectedItem.ToString() + " " + domainUpDown2.SelectedItem.ToString());
                    MessageBox.Show("Actividad creada");
                    textBox2.Text = " ";
                    writer.Close();
                    txt.Close();
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
                string[] lines = System.IO.File.ReadAllLines(carpeta+"/"+"Actividades.txt");
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
            Principal fbd = new Principal();
            var client = new FacebookClient(this.access_token);
            client.Post("/me/feed", new { message = "Proyecto Agenda"+textBox3.Text });
            MessageBox.Show("Actividad publicada con exito");
        }

        private void Agenda_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
