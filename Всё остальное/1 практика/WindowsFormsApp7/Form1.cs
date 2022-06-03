using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(textBox1.Text);
            double p = Convert.ToDouble(textBox2.Text);
            double a = Convert.ToDouble(textBox3.Text);
            double r1 = Convert.ToDouble(textBox4.Text);

            double m = (i * p * ((r1 + a) * 2) - (r1) * 2) * p;
            textBox7.Text = m.ToString();



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(textBox1.Text);
            double p = Convert.ToDouble(textBox2.Text);
            double a = Convert.ToDouble(textBox3.Text);
            double r1 = Convert.ToDouble(textBox4.Text);
            double v = (p * (r1 + a) * i);
            textBox6.Text = v.ToString();
        }
    }
}
