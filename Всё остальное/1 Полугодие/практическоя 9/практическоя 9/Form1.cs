using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace практическоя_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                if (listBox1.Items.Count == 0)
                {
                    button4.Enabled = false;
                }
                button2.Enabled = false;
                button3.Enabled = false;
            }
        }
       
    

                
                   

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            //f.Show();
            if (f.ShowDialog() == DialogResult.OK)
            {
                string info = f.textBox1.Text;
                int s = Convert.ToInt32(f.textBox2.Text);
                int m = Convert.ToInt32(f.textBox3.Text);
                double z = Convert.ToDouble(f.textBox4.Text);
                sklad p = new sklad();
                p.poroda = info;
                p.dlinahersti = s;
                p.sredniirost = m;
                p.sredniives = z;
                listBox1.Items.Add(p);
                f.textBox1.Text = "";
                f.textBox2.Text = "";
                f.textBox3.Text = "";
                f.textBox4.Text = "";

                button4.Enabled = false;



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
                sklad p = listBox1.Items[k] as sklad;
                Form2 f = new Form2();
                f.textBox1.Text = p.poroda;
                f.textBox2.Text = p.dlinahersti.ToString();
                f.textBox3.Text = p.sredniirost.ToString();
                f.textBox4.Text = p.sredniives.ToString();
                if (f.ShowDialog() == DialogResult.OK)
                {

                    p.poroda = f.textBox1.Text;
                    p.dlinahersti = Convert.ToInt32(f.textBox2.Text);
                    p.sredniirost = Convert.ToInt32(f.textBox3.Text);
                    p.sredniives = Convert.ToDouble(f.textBox4.Text);
                    listBox1.Items[k] = p;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                sklad p = listBox1.Items[i] as sklad;
                sum += p.dlinahersti;
            }
            MessageBox.Show(listBox1.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                while (!sr.EndOfStream)
                {
                    sklad p = new sklad();
                    p.poroda = sr.ReadLine();
                    p.dlinahersti = Convert.ToInt32(sr.ReadLine());
                    p.sredniirost = Convert.ToInt32(sr.ReadLine());
                    p.sredniives = Convert.ToDouble(sr.ReadLine());
                    listBox1.Items.Add(p);
                }
                sr.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    sklad p = listBox1.Items[i] as sklad;
                    sw.WriteLine(p.poroda);
                    sw.WriteLine(p.dlinahersti);
                    sw.WriteLine(p.sredniirost);
                    sw.WriteLine(p.sredniives);

                }
                sw.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
            }

        }
    }
}
    

