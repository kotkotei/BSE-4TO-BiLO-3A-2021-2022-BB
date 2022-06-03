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

namespace _25._10
{

    public partial class Form1 : Form
    {
        public struct Person 
        {
            public string FIO;
            public DateTime date;
            public char pol;
            public double ves;
            public int rost;
        }
    public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.RowCount = Convert.ToInt32(numericUpDown1.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.RowCount = Convert.ToInt32(numericUpDown1.Value);
            Person[] mas = new Person[n];
            for (int i = 0; i < n; i++) 
            {
                mas[i].FIO = dataGridView1[0,i].Value.ToString();
                mas[i].date =Convert.ToDateTime( dataGridView1[1, i].Value);
                mas[i].pol = Convert.ToChar(dataGridView1[2, i].Value);
                mas[i].ves = Convert.ToDouble(dataGridView1[3, i].Value);
                mas[i].rost = Convert.ToInt32(dataGridView1[4, i].Value);
            }
            int sum = 0;
            DateTime d = DateTime.Today;
            for (int i = 0; i < n; i++)
            {
                int k = d.Year - mas[i].date.Year;
                if (d.Month < mas[i].date.Month)
                {
                    k = k - 1;
                }
                else if (d.Month < mas[i].date.Month && d.Day < mas[i].date.Day)
                {
                    k = k - 1;
                }
                sum = sum + k;
            }
            string s= (sum * 1.0 / n).ToString();
                                
            MessageBox.Show(s);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.RowCount = Convert.ToInt32(numericUpDown1.Value);
            Person[] mas = new Person[n];
            for (int i = 0; i < n; i++)
            {
                mas[i].FIO = dataGridView1[0, i].Value.ToString();
                mas[i].date = Convert.ToDateTime(dataGridView1[1, i].Value);
                mas[i].pol = Convert.ToChar(dataGridView1[2, i].Value);
                mas[i].ves = Convert.ToDouble(dataGridView1[3, i].Value);
                mas[i].rost = Convert.ToInt32(dataGridView1[4, i].Value);
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += mas[i].rost;

            }
            string s = (sum * 1.0 / n).ToString();
            MessageBox.Show(s);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
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
                    mas[i].FIO = dataGridView1[0, i].Value.ToString();
                    mas[i].date = Convert.ToDateTime(dataGridView1[1, i].Value);
                    mas[i].pol = Convert.ToChar(dataGridView1[2, i].Value);
                    mas[i].ves = Convert.ToDouble(dataGridView1[3, i].Value);
                    mas[i].rost = Convert.ToInt32(dataGridView1[4, i].Value);
                }
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName,
                    false, System.Text.Encoding.Default);
                for (int i = 0; i < n; i++)
                {
                    sw.WriteLine(mas[i].FIO);
                    sw.WriteLine(mas[i].date);
                    sw.WriteLine(mas[i].pol);
                    sw.WriteLine(mas[i].ves);
                    sw.WriteLine(mas[i].rost);
                }
                sw.Close();

            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                StreamReader sr = new StreamReader(saveFileDialog1.FileName,
               System.Text.Encoding.Default);
                Person[] mas = new Person[0];
                int k = 0;
                while (!sr.EndOfStream)
                {
                    k++;
                    Array.Resize(ref mas, k);
                    mas[k - 1].FIO = sr.ReadLine();
                    mas[k - 1].date =Convert.ToDateTime (sr.ReadLine());
                    mas[k - 1].pol = Convert.ToChar(sr.ReadLine());
                    mas[k - 1].ves = Convert.ToDouble(sr.ReadLine());
                    mas[k - 1].rost = Convert.ToInt32(sr.ReadLine());
                }
                sr.Close();
                dataGridView1.RowCount = k;
                numericUpDown1.Value = k;
                for (int i = 0; i < k; i++)
                {
                    dataGridView1[0, i].Value = mas[i].FIO;
                    dataGridView1[1, i].Value = mas[i].date;
                    dataGridView1[2, i].Value = mas[i].pol;
                    dataGridView1[3, i].Value = mas[i].ves;
                    dataGridView1[4, i].Value = mas[i].rost;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
