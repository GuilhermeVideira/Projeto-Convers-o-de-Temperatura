using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversao_de_temperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double Farenheit;
        private double Celsius;
        private double Kelvin;

        private double FarenheitToCelsius
        {
            get { return (Farenheit - 32) * 5 / 9; }
            set { Farenheit = value; }
        }

        private double FarenheitToKelvin
        {
            get { return (Farenheit - 32) * 5 / 9 + 273.15; }
            set { Farenheit = value; }
        }

        private double CelsiusToKelvin
        {
            get { return Celsius + 273.15; }
            set { Celsius = value; }
        }

        private double CelsiusToFarenheit
        {
            get { return (Celsius * 9 / 5) + 32; }
            set { Celsius = value; }
        }

        private double KelvinToCelsius
        {
            get { return Kelvin - 273.15; }
            set { Kelvin = value; }
        }

        private double KelvinToFarenheit
        {
            get { return (Kelvin - 273.15) * 9/5 + 32; }
            set { Kelvin = value; }
        }

        private void Converter()
        {
            try { 
            if (string.IsNullOrEmpty(textBox1.Text) || textBox1.Text == "-")
            {
                textBox2.Text = "";

            } 
            else if(comboBox1.Text == "Farenheit --- Celsius ")
            {
                FarenheitToCelsius = Convert.ToDouble(textBox1.Text);
                textBox2.Text = FarenheitToCelsius.ToString();
            }
            else if (comboBox1.Text == "Farenheit --- Kelvin ")
            {
                FarenheitToKelvin = Convert.ToDouble(textBox1.Text);
                textBox2.Text = FarenheitToKelvin.ToString();
            }
            else if (comboBox1.Text == "Celsius --- Farenheit")
            {
                CelsiusToFarenheit = Convert.ToDouble(textBox1.Text);
                textBox2.Text = CelsiusToFarenheit.ToString();
            }
            else if (comboBox1.Text == "Celsius --- Kelvin")
            {
                CelsiusToKelvin = Convert.ToDouble(textBox1.Text);
                textBox2.Text = CelsiusToKelvin.ToString();
            }
            else if (comboBox1.Text == "Kelvin --- Celsius")
            {
                KelvinToCelsius = Convert.ToDouble(textBox1.Text);
                textBox2.Text = KelvinToCelsius.ToString();
            }
            else if (comboBox1.Text == "Kelvin --- Farenheit")
            {
                KelvinToFarenheit = Convert.ToDouble(textBox1.Text);
                textBox2.Text = KelvinToFarenheit.ToString();
            }
          } catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if ((ch == 46 && textBox1.Text.IndexOf(" . ") != -1) ||
            (ch == 45 && textBox1.Text.IndexOf(" - ") != -1) ||
            (ch == 45 && textBox1.Text.IndexOf(" . ") != -1) ||

            (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 45))

            {
                e.Handled = true;
                return;
            }

        }

        private void ChangeLabel1()
        {
            switch(comboBox1.Text)
            {
                case "Farenheit --- Celsius":
                    label1.Text = "Farenheit";
                    label2.Text = "Celsius";
                    break;

                case "Farenheit --- Kelvin":
                    label1.Text = "Farenheit";
                    label2.Text = "Kelvin";
                    break;

                case "Celsius --- Kelvin":
                    label1.Text = "Celsius";
                    label2.Text = "Kelvin";
                    break;

                case "Celsius --- Farenheit":
                    label1.Text = "Celsius";
                    label2.Text = "Farenheit";
                    break;

                case "Kelvin --- Farenheit":
                    label1.Text = "Kelvin";
                    label2.Text = "Farenheit";
                    break;

                case "Kelvin --- Celsius":
                    label1.Text = "Kelvin";
                    label2.Text = "Celsius";
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Converter();
            ChangeLabel1();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Converter();
        }
    }
}
