using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическоя_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string info = textBox1.Text;
            int s = Convert.ToInt32(textBox2.Text);
            double v = Convert.ToDouble(textBox3.Text);
            Sklad p = new Sklad();
            p.info = info;
            p.stoimist = s;
            p.obiom = v;
            listBox1.Items.Add(p);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Вы не выброли что удалять ");
            }
            else
            {
                int k = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(k);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбрано ");
            }
            else
            {
                int k = listBox1.SelectedIndex;
                Sklad p = listBox1.Items[k] as Sklad;
                textBox1.Text = p.info;
                textBox2.Text = p.stoimist.ToString();
                textBox3.Text = p.obiom.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int k = listBox1.SelectedIndex;
           Sklad p = listBox1.Items[k] as Sklad;
            p.info = textBox1.Text;
            p.stoimist = Convert.ToInt32(textBox2.Text);
            p.obiom = Convert.ToDouble(textBox3.Text);
            listBox1.Items[k] = p;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                Sklad p = listBox1.Items[i] as Sklad;
                sum += p.stoimist;
            }
            MessageBox.Show((sum * 1.0 / listBox1.Items.Count).ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double sum = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                Sklad p = listBox1.Items[i] as Sklad;
                sum += p.obiom;
            }
            MessageBox.Show((sum * 1.0 / listBox1.Items.Count).ToString());
        }
    }
}
