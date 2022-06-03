using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {

                MessageBox.Show("Не выбрано");

            }
            else
            {

                int n = comboBox1.SelectedIndex;
                string s = comboBox1.Items[n].ToString();
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = a + b;
                textBox3.Text = c.ToString();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                int n = comboBox1.SelectedIndex;
                string s = comboBox1.Items[n].ToString();
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = a - b;
                textBox3.Text = c.ToString();

            }
            if (comboBox1.SelectedIndex == 2)
            {
                int n = comboBox1.SelectedIndex;
                string s = comboBox1.Items[n].ToString();
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = a * b;
                textBox3.Text = c.ToString();
            }
            if (comboBox1.SelectedIndex == 3)
            {
                int n = comboBox1.SelectedIndex;
                string s = comboBox1.Items[n].ToString();
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = a / b;
                textBox3.Text = c.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
