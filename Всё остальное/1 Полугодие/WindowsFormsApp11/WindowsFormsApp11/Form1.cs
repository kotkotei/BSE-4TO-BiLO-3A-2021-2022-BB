using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        int c = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int b = trackBar1.Value;
            pictureBox1.Size = new System.Drawing.Size(pictureBox1.Size.Width + b * 10,
                pictureBox1.Size.Width + b * 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(trackBar1.Value);
            MessageBox.Show(n.ToString());
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            c = c + 1;
            progressBar1.Value = c;
            toolStripStatusLabel1.Text = c + " % ";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c = 0;
            progressBar1.Value = c;
            toolStripStatusLabel1.Text = c + " % ";
        }
    }
    }

