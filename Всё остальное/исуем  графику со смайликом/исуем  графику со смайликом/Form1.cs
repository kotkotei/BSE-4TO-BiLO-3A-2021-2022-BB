using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace исуем__графику_со_смайликом
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            //Pen p = new Pen(Color.Black);
            Pen p = new Pen(pictureBox3.BackColor);
            p.Width = Convert.ToInt32(numericUpDown5.Value);
            //SolidBrush b = new SolidBrush(Color.Yellow);
            SolidBrush b = new SolidBrush(pictureBox2.BackColor);
            int x = Convert.ToInt32(numericUpDown1.Value);
            int y = Convert.ToInt32(numericUpDown2.Value);
            int h = Convert.ToInt32(numericUpDown3.Value);
            int w = Convert.ToInt32(numericUpDown4.Value);
            g.FillRectangle(b, x, y, h, w);
            g.DrawRectangle(p, x, y, h, w);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            //Pen p = new Pen(Color.Black);
            Pen p = new Pen(pictureBox3.BackColor);
            p.Width = Convert.ToInt32(numericUpDown5.Value);
            //SolidBrush b = new SolidBrush(Color.Yellow);
            SolidBrush b = new SolidBrush(pictureBox2.BackColor);
            int x = Convert.ToInt32(numericUpDown1.Value);
            int y = Convert.ToInt32(numericUpDown2.Value);
            int h = Convert.ToInt32(numericUpDown3.Value);
            int w = Convert.ToInt32(numericUpDown4.Value);
            g.FillEllipse(b, x, y, h, w);
            g.DrawEllipse(p, x, y, h, w);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox2.BackColor = colorDialog1.Color;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox3.BackColor = colorDialog1.Color;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = 100;
            numericUpDown2.Value = 200;
            numericUpDown3.Value = 200;
            numericUpDown4.Value = 200;
            numericUpDown5.Value = 8;
            pictureBox3.BackColor = Color.Black;
            pictureBox2.BackColor = Color.White;
            pictureBox6.BackColor = Color.Orange;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = new Bitmap(pictureBox4.Width, pictureBox4.Height);
            Graphics g = Graphics.FromImage(pictureBox4.Image);
            Pen p = new Pen(pictureBox2.BackColor);            
            SolidBrush b = new SolidBrush(pictureBox2.BackColor);
            int h = 200;
            g.FillEllipse(b, 57, 98, h, h);
            SolidBrush b2 = new SolidBrush(pictureBox3.BackColor);
            g.FillEllipse(b2, 100 + h / 2 - 20 - h / 8, 100 + h / 4, 40, 20);            
            g.FillEllipse(b2, 100 + h / 2 + h / 8, 100 + h / 4, 40, 40);         
            SolidBrush b3 = new SolidBrush(pictureBox5.BackColor);
            g.FillRectangle(b3,96 + h / 2 - 10 - h / 8, 97 + h / 2 + h / 8, 10 + 10 + h / 8 + h / 8, 12);
            SolidBrush b4 = new SolidBrush(pictureBox6.BackColor);
            g.FillRectangle(b4,40 + h / 2 - 10 - h / 8, 56 + h / 8, 120, 30);


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox5.BackColor = colorDialog1.Color;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox6.BackColor = colorDialog1.Color;
                }
            }
        }
    }
}
