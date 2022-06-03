using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Какитио_там_дроби
{
    public partial class Form1 : Form
    {
        Fractoin f, f2;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            domainUpDown1.SelectedIndex = 0;
            domainUpDown3.SelectedIndex = 0;
            domainUpDown2.SelectedIndex = 0;
        }
        public void Print()
        {
            if (f.sign > 0)
            {
                domainUpDown3.SelectedIndex = 0;
            }
            else
            {
                domainUpDown3.SelectedIndex = 1;
            }
            textBox7.Text = f.integer.ToString();
            textBox8.Text = f.numerator.ToString();
            textBox9.Text = f.denominator.ToString();
            
        }
        public void ReceiveF()
        {
            int sign = 1;
            if (domainUpDown1.SelectedIndex == 1)
            {
                sign = -1; ;
            }
            else if (domainUpDown1.SelectedIndex == 0)
            {
                sign = 1;
            }
            int inreger = Convert.ToInt32(textBox1.Text);
            int numerater = Convert.ToInt32(textBox2.Text);
            int denominator = Convert.ToInt32(textBox3.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int sign = 1;
            if (domainUpDown1.SelectedIndex == 1)
            {
                sign= - 1;
            }
            else if (domainUpDown1.SelectedIndex == 0)
            {
                sign = 1;
            }
            int integer = Convert.ToInt32(textBox1.Text);
            int numerator = Convert.ToInt32(textBox2.Text);
            int denominator = Convert.ToInt32(textBox3.Text);

            f = new Fractoin(sign, integer, numerator, denominator);

            f.Reduction();

            if  (f.sign > 0)
            {
                domainUpDown3.SelectedIndex = 0;
            }
            else
            {
                domainUpDown3.SelectedIndex = 1;
            }
            textBox7.Text = f.integer.ToString();
            textBox8.Text = f.numerator.ToString();
            textBox9.Text = f.denominator.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sign = 1;
            if (domainUpDown1.SelectedIndex == 1)
            {
                sign = -1;
            }
            else if (domainUpDown1.SelectedIndex == 0)
            {
                sign = 1;
            }
            int integer = Convert.ToInt32(textBox1.Text);
            int numerator = Convert.ToInt32(textBox2.Text);
            int denominator = Convert.ToInt32(textBox3.Text);

            f = new Fractoin(sign, integer, numerator, denominator);

            f.Reduction();

            if (f.sign > 0)
            {
                domainUpDown3.SelectedIndex = 0;
            }
            else
            {
                domainUpDown3.SelectedIndex = 1;
            }
            textBox7.Text = f.integer.ToString();
            textBox8.Text = f.numerator.ToString();
            textBox9.Text = f.denominator.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sign = 1;
            if (domainUpDown1.SelectedIndex == 1)
            {
                sign = -1;
            }
            else if (domainUpDown1.SelectedIndex == 0)
            {
                sign = 1;
            }
            int integer = Convert.ToInt32(textBox1.Text);
            int numerator = Convert.ToInt32(textBox2.Text);
            int denominator = Convert.ToInt32(textBox3.Text);
            f = new Fractoin(sign, integer, numerator, denominator);
            f.Correct_fraction();
            if (f.sign > 0)
            {
                domainUpDown3.SelectedIndex = 0;
            }
            else
            {
                domainUpDown3.SelectedIndex = 1;
            }
            if (f.integer == 0)
            {
                textBox7.Text = f.integer.ToString();
            }
            textBox8.Text = f.numerator.ToString();
            textBox9.Text = f.denominator.ToString();
        }
    }
}
