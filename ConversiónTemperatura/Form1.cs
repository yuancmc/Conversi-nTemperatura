using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversiónTemperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float fahrenheit =
            float.Parse(textBox1.Text);
            float celcius = (fahrenheit - 32) * 5 / 9;
            textBox1.Text =
                celcius.ToString("F2");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            float celcius =
                float.Parse(textBox1.Text);
            float fahrenheit = (celcius * 9 / 5) + 32;
            textBox1.Text =
                fahrenheit.ToString("F2");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0.0";
            MessageBox.Show("Se resetearon los valores de los textos");
        }
    }
}
