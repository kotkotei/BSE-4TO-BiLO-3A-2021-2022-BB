using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проект
{
    public partial class Form1 : Form
    {
        Game g;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            this.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (g.Move(1) == false)
            {
                MessageBox.Show("Конец игры!");

            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (g.Move(2) == false)
            {
                MessageBox.Show("Конец игры!");

            }
            label2.Text = g.count.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            g = new Game(pictureBox1);
            button5.Enabled = false;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g.Move(4);
            
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            g.Move(3);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.MoveFood2();
            /*bool a= g.MoveFood2();
            if (a == false)
            {
                timer1.Stop();
                MessageBox.Show("Все!");

            }*/




            bool f=g.MoveFood();
            label2.Text = g.count.ToString();
            if (f == false)
            {
                timer1.Stop();
                MessageBox.Show("Все!");
                
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (g.Move(1) == false)
                {
                    MessageBox.Show("Все!");
                    button5.Enabled = true;
                    label2.Text = "0";
                }
                else label2.Text = g.count.ToString();
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (g.Move(2) == false)
                {
                    MessageBox.Show("Все!");
                    button5.Enabled = true;
                    label2.Text = "0";
                }
                else label2.Text = g.count.ToString();
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (g.Move(3) == false)
                {
                    MessageBox.Show("Все!");
                    button5.Enabled = true;
                    label2.Text = "0";
                }
                else label2.Text = g.count.ToString();
            }
            else if (e.KeyCode == Keys.Left)
            {
                if (g.Move(4) == false)
                {
                    MessageBox.Show("Все!");
                    button5.Enabled = true;
                    label2.Text = "0";
                }
                else label2.Text = g.count.ToString();
            }
        }
    }
}
