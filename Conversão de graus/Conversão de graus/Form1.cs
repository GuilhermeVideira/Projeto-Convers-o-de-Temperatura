using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversão_de_graus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Tcel, Tkel, Ifah;
            Tcel = int.Parse(textBox1.Text);

            Tkel = Tcel + 273;
            Ifah = (((Tcel * 9) / 5) + 32);

            label3.Text = Tkel.ToString();
            label5.Text = Ifah.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
