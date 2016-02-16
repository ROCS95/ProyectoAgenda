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

namespace JoseLedezmaAgendaSocial
{
    public partial class Agenda : Form
    {
        public Agenda()
        {
            InitializeComponent();
            label2.Visible = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            textBox2.Visible = true;
            label1.Visible = true;
            btnAgreg.Visible = true;
            
            label3.Text = DateTime.Now.ToString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionStart.ToString("dd-MMMM-yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            textBox2.Visible = false;
            label1.Visible = false;
            btnAgreg.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream txt = new FileStream("C://Users//yessenia//Documents//Visual Studio 2015//Projects//JoseLedezmaAgendaSocial//Actividades.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(txt);
            writer.WriteLine(textBox2.Text + " "+ monthCalendar1.SelectionStart.ToString("dd-MMMM-yyyy"));
            writer.Close();
            txt.Close();
        }
    }
}
