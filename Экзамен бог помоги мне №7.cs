﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary7;

namespace Время
{
    public partial class Form1 : Form
    {
        Data f, f2;
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
   
        public Data ReceiveF()
        {
            int SaJEN = Convert.ToInt32(textBox1.Text);
            int ARHIN = Convert.ToInt32(textBox2.Text);
            int VERHOK = Convert.ToInt32(textBox3.Text);
            

            Data newf= new Data(SaJEN, ARHIN, VERHOK);
            return newf;

        }
        public Data ReceiveF2()
        {
            int SAJEN2 = Convert.ToInt32(textBox4.Text);
            int ARHIN2 = Convert.ToInt32(textBox5.Text);
            int VERHOK2 = Convert.ToInt32(textBox6.Text);
            

            Data newf2= new Data(SAJEN2, ARHIN2, VERHOK2);
            return newf2;
        }

   
        private void Print(Data f)
        {
            textBox9.Text = f.SAJEN.ToString();
            textBox8.Text = f.ARHIN.ToString();
            textBox7.Text = f.VERHOK.ToString();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReceiveF();
            ReceiveF2();
            f.Subtraction(f2);
            Print(f);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Data f = ReceiveF();
                Data f2 = ReceiveF2();
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
                Data f = ReceiveF();
                Data f2 = ReceiveF2();
                f.Addition(f2);
                Print(f);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                Data f = ReceiveF();
                Data f2 = ReceiveF2();
                f.Subtraction(f2);
                Print(f);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                Data f = ReceiveF();
                Data f2 = ReceiveF2();
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
                Data f = ReceiveF();
                Data f2 = ReceiveF2();
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
                Data f = ReceiveF();
                Data f2 = ReceiveF2();
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
                Data f = ReceiveF();
                Data f2 = ReceiveF2();
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
                Data f = ReceiveF();
                Data f2 = ReceiveF2();
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
            Data f = ReceiveF();
            textBox10.Text = f.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = textBox10.Text;
            Data ff = Data.Parse(s);
            Print(ff);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void button4_Click(object sender, EventArgs e)
        {
            ReceiveF();
            ReceiveF2();
            f.Addition(f2);
            Print(f);
        }
    }
}
