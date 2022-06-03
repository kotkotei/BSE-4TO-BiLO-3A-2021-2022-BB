using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("text", "no text", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult m = MessageBox.Show("text", "no text", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            MessageBox.Show(m.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult m = MessageBox.Show("карова2", "нюша4", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            if (m == DialogResult.Yes)
            {
                MessageBox.Show("всё ок");
            }
            else
                if (m != DialogResult.Yes)
            {
                MessageBox.Show("плохо");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //System.IO.File.WriteAllText(p, textBox1.Text);
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string p = openFileDialog1.FileName;
                textBox1.Text = System.IO.File.ReadAllText(p);


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string p = saveFileDialog1.FileName;
                System.IO.File.WriteAllText(p, textBox1.Text);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (colorDialog1.ShowDialog() == DialogResult.OK)                                
            {
                Color o = colorDialog1.Color;
                pictureBox1.BackColor = o;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Font p = fontDialog1.Font;
                label1.Font = p;

            }
        }
    }
}


