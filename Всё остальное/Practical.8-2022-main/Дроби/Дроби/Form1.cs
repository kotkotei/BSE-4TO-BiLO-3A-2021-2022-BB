using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Дроби
{
    public partial class Form1 : Form
    {
        Fraction f,f2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            domainUpDown1.SelectedIndex = 0;
            domainUpDown2.SelectedIndex = 0;
            domainUpDown3.SelectedIndex = 0;
        }
        public void Print()
        {
            if (f.sign > 0)
            {
                domainUpDown2.SelectedIndex = 0;
            }
            else
            {
                domainUpDown2.SelectedIndex = 1;
            }
            textBox4.Text = f.integer.ToString();
            textBox5.Text = f.numeration.ToString();
            textBox6.Text = f.denominator.ToString();
        }
        public void ReceiveF()
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

            f = new Fraction(sign, integer, numerator, denominator);
        }
        public void ReceiveF2()
        {
            int sign2 = 1;
            if (domainUpDown3.SelectedIndex == 1)
            {
                sign2 = -1;

            }
            else if (domainUpDown3.SelectedIndex == 0)
            {
                sign2 = 1;
            }
            int integer2 = Convert.ToInt32(textBox9.Text);
            int numerator2 = Convert.ToInt32(textBox8.Text);
            int denominator2 = Convert.ToInt32(textBox7.Text);

            f2 = new Fraction(sign2, integer2, numerator2, denominator2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReceiveF();
            f.Reduction();
            Print();
     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReceiveF();
            f.Incorrect_fraction();
            Print();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReceiveF();
            f.Correct_fraction();
            Print();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReceiveF();
            ReceiveF2();
            f.Addition(f2);
            Print();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ReceiveF();
            ReceiveF2();
            f.Subtrachion(f2);
            Print();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ReceiveF();
            ReceiveF2();
            f.Multiplication(f2);
            Print();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ReceiveF();
            ReceiveF2();
            f.Division(f2);
            Print();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked)
            {
                ReceiveF();
                f.Reduction();
                Print();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                ReceiveF();
                f.Incorrect_fraction();
                Print();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                ReceiveF();
                f.Correct_fraction();
                Print();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                ReceiveF();
                ReceiveF2();
                f.Addition(f2);
                Print();
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                ReceiveF();
                ReceiveF2();
                f.Subtrachion(f2);
                Print();
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                ReceiveF();
                ReceiveF2();
                f.Multiplication(f2);
                Print();
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                ReceiveF();
                ReceiveF2();
                f.Division(f2);
                Print();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
