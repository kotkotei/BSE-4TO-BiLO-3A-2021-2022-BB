using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void рисунок1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Рисунок1 = new Form2();
            Рисунок1.ShowDialog();

        }

        private void рисунок2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 Рисунок2 = new Form3();
            Рисунок2.ShowDialog();
        }

        private void рисунок3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 Рисунок3 = new Form4();
            Рисунок3.ShowDialog();
        }
    }
}
