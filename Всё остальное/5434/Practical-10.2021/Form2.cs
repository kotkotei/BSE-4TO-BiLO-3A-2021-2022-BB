using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_10._2021
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

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                int k = 0;
                try
                {
                    if (textBox2.Text == "")
                    {
                        textBox2.Focus();
                        throw new Exception("Вы не ввели ФИО");
                    }
                    int s = Convert.ToInt32(textBox3.Text);
                    k++;
                    int kl = Convert.ToInt32(textBox4.Text);
                    k++;
                    int t = Convert.ToInt32(textBox5.Text);


                }
                catch (FormatException)
                {
                    if (k == 0)
                    {
                        textBox3.Focus();
                        MessageBox.Show("Школа- целое число");
                    }
                    else if (k == 1)
                    {
                        textBox4.Focus();
                        MessageBox.Show("Класс -целое число");
                    }
                    else if (k == 2)
                    {
                        textBox5.Focus();
                        MessageBox.Show("тест -целое число");
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
