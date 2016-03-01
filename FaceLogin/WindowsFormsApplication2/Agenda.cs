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
        public Agenda(string name, string gender, string mail)
        {
            InitializeComponent();
            label2.Visible = true;
            numericUpDown1.Visible = false;
            lblname.Text = name;
            lblgender.Text = gender;
            lblemail.Text = mail;
        }

        private void pictBxMost_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            textBox2.Visible = true;
            label1.Visible = true;
            btnAgreg.Visible = true;
            numericUpDown1.Visible = true;
            label3.Text = DateTime.Now.ToString();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            textBox2.Visible = false;
            label1.Visible = false;
            btnAgreg.Visible = false;
        }

        private void btnAgreg_Click(object sender, EventArgs e)
        {
            FileStream txt = new FileStream("Actividades.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(txt);
            writer.WriteLine(textBox2.Text + " " + monthCalendar1.SelectionStart.ToString("dd-MMMM-yyyy"));
            writer.Close();
            txt.Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionStart.ToString("dd-MMMM-yyyy");
        }
    }
}
