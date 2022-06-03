using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace практическоя_9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                int k = 0;
                try
                {
                    if (textBox1.Text == "")
                    {
                        textBox1.Focus();
                        throw new Exception("Вы не ввели Породу собаки");
                    }
                    int info = Convert.ToInt32(textBox1.Text);
                    k++;
                    int s = Convert.ToInt32(textBox2.Text);
                    k++;
                    int m = Convert.ToInt32(textBox3.Text);
                    k++;
                    int z = Convert.ToInt32(textBox4.Text);


                }
                catch (FormatException)
                {
                    if (k == 0)
                    {
                        textBox2.Focus();
                        MessageBox.Show("Длина шерти целое");
                    }
                    else if (k == 1)
                    {
                        textBox3.Focus();
                        MessageBox.Show("Рост целое");
                    }
                    else if (k == 2)
                    {
                        textBox4.Focus();
                        MessageBox.Show("Дробное");
                    }

                    e.Cancel = true;
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.Message);
                    e.Cancel = true;
                }
            }
        }
    }
}

