using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr2
{
    public partial class Form1 : Form
    {
        public static int max_x = 550;
        public static int max_y = 310;
        public static int x0 = 10;
        public static int y0 = 10;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            Pen p = new Pen(Color.Red);
            g.DrawLine(p, x0, y0 + max_y / 2, x0 + max_x, y0 + max_y / 2);
            g.DrawLine(p, x0, y0, x0, y0 + max_y);
            double[] mas_x = new double[100];
            double[] mas_y = new double[100];
            dataGridView1.RowCount = 100;
            for (int i = 0; i < 100; i++)
            {
                mas_x[i] = i;
                if (radioButton1.Checked)
                {

                    mas_y[i] = Math.Sqrt(i);
                }
                else
                {
                    if (i != 0)
                    {
                        mas_y[i] = 6/ i;
                    }
                    else
                    {
                        mas_y[0] = 6 / 1;
                    }
                }
                dataGridView1[0, i].Value = mas_x[i];
                dataGridView1[1, i].Value = mas_y[i];
            }
            int kx = 5;
            int ky = 5;
            for (int i = 1; i < 100; i++)
            {
                int x1_1 = (Convert.ToInt32(mas_x[i - 1]) * kx + x0);
                int y1_1 = (-(Convert.ToInt32(mas_y[i - 1]) * ky) + y0 + max_y / 2);
                int x1_2 = (Convert.ToInt32(mas_x[i]) * kx + x0);
                int y1_2 = (-(Convert.ToInt32(mas_y[i]) * ky) + y0 + max_y / 2);
                g.DrawLine(p, x1_1, y1_1, x1_2, y1_2);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = max_x;
            
            int k1 = Convert.ToInt32(numericUpDown1.Value);
            int k2 = Convert.ToInt32(numericUpDown2.Value);
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            Pen p = new Pen(Color.Red);
            g.DrawLine(p, x0, y0 + max_y /2, x0 + max_x, y0 + max_y / 2);
            g.DrawLine(p, x0+max_x/2, y0, x0+max_x/2, y0+max_y);
            double[] mas_y = new double[count];
            for (int i = 0; i < count; i++)
            {
                if (radioButton1.Checked)
                {
                    mas_y[i] = Math.Round(k1 * Math.Sin(k2 * Math.PI / 100 * i));

                }
                else
                {
                    //mas_y[i] = Math.Round(k1 * Math.Sin(k2 * Math.PI / 100 * i));
                    if (i == 0)
                    {
                        mas_y[i] = 400 / (i + 1);
                    }
                    else
                    {
                        mas_y[i] = 400 / i;
                    }
                }
            }
            for (int i = 0; i < count - 1; i++)
            {
                g.DrawLine(p,
                    x0+max_x/2 + i,
                    y0 - Convert.ToInt32(mas_y[i]) + max_y/2,
                    x0+max_x/2 + i + 1,
                    y0 - Convert.ToInt32(mas_y[i + 1]) + max_y/2);
                g.DrawLine(p,
                    x0+i,
                    y0 - Convert.ToInt32(mas_y[i]) + max_y ,
                    x0+ i + 1,
                    y0 - Convert.ToInt32(mas_y[i + 1]) + max_y );
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = 10;
            numericUpDown2.Value = 10;
            numericUpDown1.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Visible = false;
        }
    }
}
