using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp21
{
    public partial class Form1 : Form
    {
        
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


        public void Print(Fraction f)
        {
           
            if (f.sign > 0)
            {
                domainUpDown2.SelectedIndex = 0;
            }
            else
            {
                domainUpDown2.SelectedIndex = 1;
            }
            textBox6.Text = f.integer.ToString();
            textBox5.Text = f.numerator.ToString();
            textBox4.Text = f.denominator.ToString();
        }

        public Fraction ReceiveF()
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

            int integer = Convert.ToInt32(textBox2.Text);
            int numerator = Convert.ToInt32(textBox1.Text);
            int denominator = Convert.ToInt32(textBox3.Text);

            Fraction newf = new Fraction(sign, integer, numerator, denominator);
            return newf;
        }

        public Fraction ReceiveF2()
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

            Fraction newf2 = new Fraction(sign2, integer2, numerator2, denominator2);
            return newf2;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Fraction f = ReceiveF();
          
            f.Reduction();
            Print(f);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fraction f = ReceiveF();
            ReceiveF();
            f.Incorrect_fraction();
            Print(f);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Fraction f = ReceiveF();
          
            f.Correct_fraction();
            Print(f);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Fraction f = ReceiveF();
            Fraction f2 = ReceiveF2();
            f.Subtraction(f2);
            Print(f2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Fraction f = ReceiveF();
            Fraction f2=ReceiveF2();
            f.Multiplication(f2);
            Print(f2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            
                Fraction f1 = ReceiveF();
                Fraction f2 = ReceiveF2();
                Fraction f3 = f1 + f2;
                //Fraction f4 = f1 * f2;
                // Fraction f5 = f1 - f2;
                //Fraction f6 = f1 / f2;
                Print(f3);
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fraction f = ReceiveF();
            Fraction f2 = ReceiveF2();
            f.Addition(f2);
            Print(f2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Fraction f1 = ReceiveF();
            Fraction f2 = ReceiveF2(); 
            Fraction f5 = f1 - f2;
            Print(f5);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Fraction f1 = ReceiveF();
            Fraction f2 = ReceiveF2();       
            Fraction f4 = f1 * f2;
            Print(f4);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Fraction f1 = ReceiveF();
            Fraction f2 = ReceiveF2();
            Fraction f6 = f1 / f2;
            Print(f6);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
           
            Fraction f = ReceiveF();
            Fraction f2 = ReceiveF2();
            f.Division(f2);
            Print(f2);
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Fraction f1 = ReceiveF();
                Fraction f2 = ReceiveF2();
                Fraction f3 = f1 + f2;
                //Fraction f4 = f1 * f2;
                // Fraction f5 = f1 - f2;
                //Fraction f6 = f1 / f2;
                Print(f3);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Fraction f1 = ReceiveF();
                Fraction f2 = ReceiveF2();
                Fraction f5 = f1 - f2;
                Print(f5);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                Fraction f1 = ReceiveF();
                Fraction f2 = ReceiveF2();
                Fraction f4 = f1 * f2;
                Print(f4);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                Fraction f1 = ReceiveF();
                Fraction f2 = ReceiveF2();
                Fraction f6 = f1 / f2;
                Print(f6);
            }
        }
    }
}
