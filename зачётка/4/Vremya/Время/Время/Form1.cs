using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary4;
namespace Время
{
    public partial class Form1 : Form
    {
        Time f, f2;
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
        public void Print(Time f)
        {
            textBox9.Text = f.hour.ToString();
            textBox8.Text = f.minutes.ToString();
            textBox7.Text = f.seconds.ToString();
        }
        public Time ReceiveF()
        {
            int hour = Convert.ToInt32(textBox1.Text);
            int minutes = Convert.ToInt32(textBox2.Text);
            int seconds = Convert.ToInt32(textBox3.Text);

            Time newf= new Time(hour, minutes, seconds);
            return newf;

        }
        public Time ReceiveF2()
        {
            int hour2 = Convert.ToInt32(textBox4.Text);
            int minutes2 = Convert.ToInt32(textBox5.Text);
            int seconds2 = Convert.ToInt32(textBox6.Text);

            Time newf2= new Time(hour2, minutes2, seconds2);
            return newf2;
        }

        public void Addition(Time d)//сложение времени 
        { 
            
        }
        public void Print()
        {
            textBox9.Text = f.hour.ToString();
            textBox8.Text = f.minutes.ToString();
            textBox7.Text = f.seconds.ToString();
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
                Time f = ReceiveF();
                Time f2 = ReceiveF2();
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
                Time f1 = ReceiveF();
                Time f2 = ReceiveF2();
                Time f3 = f1 + f2;
                Print(f3);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                Time f1 = ReceiveF();
                Time f2 = ReceiveF2();
                Time f4 = f1 - f2;
                Print(f4);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                Time f = ReceiveF();
                Time f2 = ReceiveF2();
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
                Time f = ReceiveF();
                Time f2 = ReceiveF2();
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
                Time f = ReceiveF();
                Time f2 = ReceiveF2();
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
                Time f = ReceiveF();
                Time f2 = ReceiveF2();
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
                Time f = ReceiveF();
                Time f2 = ReceiveF2();
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
            Time f = ReceiveF();
            textBox10.Text = f.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = textBox10.Text;
            Time ff = Time.Parse(s);
            Print(ff);
        }

        private void Form1_Load(object sender, EventArgs e)
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
