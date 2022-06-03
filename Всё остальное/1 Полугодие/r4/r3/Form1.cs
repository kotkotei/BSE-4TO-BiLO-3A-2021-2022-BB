using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace r3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = a + b;
                textBox3.Text = c.ToString();
            }
            else
            {
                if (radioButton2.Checked)
                {
                    double a = Convert.ToDouble(textBox1.Text);
                    double b = Convert.ToDouble(textBox2.Text);
                    double c = a - b;
                    textBox3.Text = c.ToString();
                }
                else
                {
                    if (radioButton3.Checked)
                    {
                        double a = Convert.ToDouble(textBox1.Text);
                        double b = Convert.ToDouble(textBox2.Text);
                        double c = a * b;
                        textBox3.Text = c.ToString();
                    }
                    else
                    {
                        if (radioButton4.Checked)
                        {
                            double a = Convert.ToDouble(textBox1.Text);
                            double b = Convert.ToDouble(textBox2.Text);
                            double c = a / b;
                            textBox3.Text = c.ToString();
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DateTime d = monthCalendar1.SelectionStart;
            MessageBox.Show(d.ToString());
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime d = dateTimePicker1.Value;
            textBox4.Text = d.ToString();
            DateTime b = monthCalendar1.SelectionStart;
            textBox5.Text = b.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }
    }
}

