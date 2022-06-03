using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR5._2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            if (radioButton1.Checked)
            {
                //Цилиндр
                f.Text = "Добавление цилиндра";
                f.textBox3.Visible = false;
                f.label3.Visible = false;
                f.textBox4.Visible = false;
                f.label4.Visible = false;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    double x = Convert.ToDouble(f.textBox1.Text);
                    double y = Convert.ToDouble(f.textBox2.Text);
                    Cl r = new Cl(x, y);
                    listBox1.Items.Add(r);
                }
            }
            else if (radioButton2.Checked)
            {
                f.Text = "Куб";
                f.textBox2.Visible = false;
                f.label2.Visible = false;
                f.textBox3.Visible = false;
                f.label3.Visible = false;
                f.textBox4.Visible = false;
                f.label4.Visible = false;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    double x = Convert.ToDouble(f.textBox1.Text);

                    Сube cu = new Сube(x);
                    listBox1.Items.Add(cu);

                }
            }
            else
            {
                f.Text = "Добавление тубы";
                f.textBox2.Visible = false;
                f.label2.Visible = false;
              
                if (f.ShowDialog() == DialogResult.OK)
                {
                    
                    double r1 = Convert.ToDouble(f.textBox3.Text);
                    double r2 = Convert.ToDouble(f.textBox4.Text);
                    double x = Convert.ToDouble(f.textBox1.Text);
                    Tuba tu = new Tuba(r1,r2,x);
                    listBox1.Items.Add(tu);
                }

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Parents p = listBox1.Items[listBox1.SelectedIndex] as Parents;
                textBox1.Text = p.S().ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Объект не выбран");
            }
            else
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
               
            }
        }
    }
}
