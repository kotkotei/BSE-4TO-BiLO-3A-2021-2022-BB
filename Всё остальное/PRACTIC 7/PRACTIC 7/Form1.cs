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


namespace PRACTIC_7
{
    public partial class Form1 : Form
    {
        public struct Person
        {
            public string yspex;
            public string bykva ;
            public int s1po11;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.RowCount = Convert.ToInt32(numericUpDown1.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                int n = dataGridView1.RowCount = Convert.ToInt32(numericUpDown1.Value);
                Person[] mas = new Person[n];
                for (int i = 0; i < n; i++)
                {
                    mas[i].yspex = dataGridView1[0, i].Value.ToString();
                    mas[i].bykva = dataGridView1[1, i].Value.ToString();
                    mas[i].s1po11 = Convert.ToInt32(dataGridView1[2, i].Value);
                }
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName,
                    false, System.Text.Encoding.Default);
                for (int i = 0; i < n; i++)
                {
                    sw.WriteLine(mas[i].yspex);
                    sw.WriteLine(mas[i].bykva);
                    sw.WriteLine(mas[i].s1po11);
                }
                sw.Close();

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                StreamReader sr = new StreamReader(saveFileDialog1.FileName,System.Text.Encoding.Default);
                Person[] mas = new Person[0];
                int k = 0;
                while (!sr.EndOfStream)
                {
                    k++;
                    Array.Resize(ref mas, k);
                    mas[k - 1].yspex = sr.ReadLine();
                    mas[k - 1].bykva = sr.ReadLine();
                    mas[k - 1].s1po11 = Convert.ToInt32(sr.ReadLine());
                }
                sr.Close();
                dataGridView1.RowCount = k;
                numericUpDown1.Value = k;
                for (int i = 0; i < k; i++)
                {
                    dataGridView1[0, i].Value = mas[i].yspex;
                    dataGridView1[1, i].Value = mas[i].bykva;
                    dataGridView1[2, i].Value = mas[i].s1po11;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.RowCount = Convert.ToInt32(numericUpDown1.Value);
            Person[] mas = new Person[n];
            for (int i = 0; i < n; i++)
            {
                mas[i].yspex = dataGridView1[0, i].Value.ToString();
                mas[i].bykva = dataGridView1[1, i].Value.ToString();
                mas[i].s1po11 = Convert.ToInt32(dataGridView1[2, i].Value);
            }
            int max = mas[0].s1po11;
            for (int i = 0; i < n; i++)
            {
                if (max < mas[i].s1po11)
                {
                    max = mas[i].s1po11;
                }
            }
            MessageBox.Show(max.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.RowCount = Convert.ToInt32(numericUpDown1.Value);
            Person[] mas = new Person[n];
            for (int i = 0; i < n; i++)
            {
                mas[i].yspex = dataGridView1[0, i].Value.ToString();
                mas[i].bykva = dataGridView1[1, i].Value.ToString();
                mas[i].s1po11 = Convert.ToInt32(dataGridView1[2, i].Value);
            }
            int min = mas[0].s1po11;
            for (int i = 0; i < n; i++)
            {
                if (min > mas[i].s1po11)
                {
                    min = mas[i].s1po11;
                }

            }
            MessageBox.Show(min.ToString());
        }
    }
}

    
