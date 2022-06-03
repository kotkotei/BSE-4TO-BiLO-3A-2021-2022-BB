using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR6._2022
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

                    Cube cu = new Cube(x);
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
                    Tuba tu = new Tuba(r1, r2, x);
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

        private void button3_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                Form2 f = new Form2();
                if (listBox1.Items[listBox1.SelectedIndex]is Cl)
                {
                    //Цилиндр
                    f.Text = "Редактирование цилиндра";
                    f.textBox3.Visible = false;
                    f.label3.Visible = false;
                    f.textBox4.Visible = false;
                    f.label4.Visible = false;
                    Cl r = listBox1.Items[listBox1.SelectedIndex] as Cl;
                    f.textBox1.Text = r.x.ToString();
                    f.textBox2.Text = r.y.ToString();
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        r.x = Convert.ToDouble(f.textBox1.Text);
                        r.y = Convert.ToDouble(f.textBox2.Text);
                        listBox1.Items[listBox1.SelectedIndex] = r; 
                       
                    }
                }
                else if (listBox1.Items[listBox1.SelectedIndex] is Cube)
                {
                    f.Text = "Редактирование Куб";
                    f.textBox2.Visible = false;
                    f.label2.Visible = false;
                    f.textBox3.Visible = false;
                    f.label3.Visible = false;
                    f.textBox4.Visible = false;
                    f.label4.Visible = false;
                    Cube r = listBox1.Items[listBox1.SelectedIndex] as Cube;
                    f.textBox1.Text = r.x.ToString();
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                         r.x = Convert.ToDouble(f.textBox1.Text);

                        listBox1.Items[listBox1.SelectedIndex] = r;

                    }
                }
                else if (listBox1.Items[listBox1.SelectedIndex] is Tuba)
                {
                    f.Text = "Редактирование тубы";
                    f.textBox2.Visible = false;
                    f.label2.Visible = false;
                    Tuba r = listBox1.Items[listBox1.SelectedIndex] as Tuba;
                    f.textBox3.Text = r.r1.ToString();
                    f.textBox4.Text = r.r2.ToString();
                    f.textBox1.Text = r.x.ToString();
                    if (f.ShowDialog() == DialogResult.OK)
                    {

                        r.r1 = Convert.ToDouble(f.textBox3.Text);
                        r.r2 = Convert.ToDouble(f.textBox4.Text);
                        r.x = Convert.ToDouble(f.textBox1.Text);
                        listBox1.Items[listBox1.SelectedIndex] = r;
                    }
                }
            }
        }
    }
}
