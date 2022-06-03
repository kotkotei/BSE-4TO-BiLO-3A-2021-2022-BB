using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary3;

namespace Время
{
    public partial class Form1 : Form
    {
        Money f, f2;
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void Print(Money f)
        {
            textBox9.Text = f.dollars.ToString();
            textBox8.Text = f.cent.ToString();
        }
        public Money ReceiveF()
        {
            int ruble = Convert.ToInt32(textBox1.Text);
            int kopeika = Convert.ToInt32(textBox2.Text);

            Money newf = new Money(ruble, kopeika);
            return newf;

        }
        public Money ReceiveF2()
        {
            int ruble2 = Convert.ToInt32(textBox4.Text);
            int kopeika2 = Convert.ToInt32(textBox5.Text);

            Money newf2 = new Money(ruble2, kopeika2);
            return newf2;
        }

        public void Addition(Money d)//сложение времени 
        { 
            
        }
        public void Print()
        {
            textBox9.Text = f.dollars.ToString();
            textBox8.Text = f.cent.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReceiveF();
            ReceiveF2();
            f.Subtraction(f2);
            Print();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Money f = ReceiveF();
                Money f2 = ReceiveF2();
                if (f >= f2)
                {
                    MessageBox.Show("Верно");
                }
                else
                {
                    MessageBox.Show("Неверно");
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Money f1 = ReceiveF();
                Money f2 = ReceiveF2();
                Money f3 = f1 + f2;
                Print(f3);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                Money f1 = ReceiveF();
                Money f2 = ReceiveF2();
                Money f4 = f1 - f2;
                Print(f4);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                Money f = ReceiveF();
                Money f2 = ReceiveF2();
                if (f <= f2)
                {
                    MessageBox.Show("Верно");
                }
                else
                {
                    MessageBox.Show("Неверно");
                }
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                Money f = ReceiveF();
                Money f2 = ReceiveF2();
                if (f < f2)
                {
                    MessageBox.Show("Верно");
                }
                else
                {
                    MessageBox.Show("Неверно");
                }
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                Money f = ReceiveF();
                Money f2 = ReceiveF2();
                if (f > f2)
                {
                    MessageBox.Show("Верно");
                }
                else
                {
                    MessageBox.Show("Неверно");
                }
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                Money f = ReceiveF();
                Money f2 = ReceiveF2();
                if (f == f2)
                {
                    MessageBox.Show("Верно");
                }
                else
                {
                    MessageBox.Show("Неверно");
                }
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                Money f = ReceiveF();
                Money f2 = ReceiveF2();
                if (f != f2)
                {
                    MessageBox.Show("Верно");
                }
                else
                {
                    MessageBox.Show("Неверно");
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Money f = ReceiveF();
            textBox10.Text = f.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = textBox10.Text;
            Money ff = Money.Parse(s);
            Print(ff);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReceiveF();
            ReceiveF2();
            f.Addition(f2);
            Print();
        }
    }
}
