using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace r5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = textBox1.Lines.Length;
            int[] mas = new int[count];
            {
                for (int i = 0; i < count; i++)
                    mas[i] = Convert.ToInt32(textBox1.Lines[i]);
            }
            int max = mas[0];
            for (int i = 1; i < count; i++)
            {
                if (max < mas[i])
                    max = mas[i];
            }
            for (int i = 1; i < count; i++)
            {
                mas[i] *= max;
            }
            for (int i = 0; i < count; i++) textBox2.AppendText(mas[i] + Environment.NewLine);
            {
                textBox1.Clear();
            }
        }
    }
}
