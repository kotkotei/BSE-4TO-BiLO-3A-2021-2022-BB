using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Матрицы
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            dataGridView2.RowCount = Convert.ToInt32(numericUpDown4.Value);
        }

            private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 1;
            dataGridView1.ColumnCount = 1;
            dataGridView2.RowCount = 1;
            dataGridView2.ColumnCount = 1;
            dataGridView3.RowCount = 1;
            dataGridView3.ColumnCount = 1;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.RowCount = Convert.ToInt32(numericUpDown1.Value);

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = Convert.ToInt32(numericUpDown2.Value);

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            dataGridView2.ColumnCount = Convert.ToInt32(numericUpDown3.Value);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m = Convert.ToInt32(numericUpDown1.Value);
            int m2 = Convert.ToInt32(numericUpDown4.Value);
            int n1 = Convert.ToInt32(numericUpDown2.Value);
            int n2 = Convert.ToInt32(numericUpDown3.Value);
            double[,] mas1 = new double[n1, m];
            double[,] mas2 = new double[n2, m2];
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas1[i, j] = Convert.ToDouble(dataGridView1[i, j].Value);
                }

            }
            for (int i = 0; i < n2; i++)
            {
                for (int j = 0; j < m2; j++)
                {
                    mas2[i, j] = Convert.ToDouble(dataGridView2[i, j].Value);

                }
            }
            if (radioButton1.Checked)
            {
                if (n1 != n2)
                {
                    MessageBox.Show("Размерность матриц не идентична");
                }
                else
                {
                    dataGridView3.RowCount = dataGridView1.RowCount;
                    dataGridView3.ColumnCount = dataGridView2.ColumnCount;
                    double[,] mas3 = new double[n2, m];
                    for (int i = 0; i < n2; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            mas3[i, j] = mas1[i, j] + mas2[i, j];
                            dataGridView3[i, j].Value = mas3[i, j].ToString();

                        }
                    }

                }

            }
            else if (radioButton2.Checked)
            {
                if (n1 != n2)
                {
                    MessageBox.Show("Размерность матриц не идентична");
                }
                else
                {
                    dataGridView3.RowCount = dataGridView1.RowCount;
                    dataGridView3.ColumnCount = dataGridView2.ColumnCount;
                    double[,] mas3 = new double[n2, m];
                    for (int i = 0; i < n2; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            mas3[i, j] = mas1[i, j] - mas2[i, j];
                            dataGridView3[i, j].Value = mas3[i, j].ToString();

                        }
                    }


                }



            }
            else if (radioButton3.Checked)
            {
                if (n1 != m)
                {
                    MessageBox.Show("умножение не возможно ");
                }
                else
                {
                    dataGridView3.RowCount = dataGridView1.RowCount;
                    dataGridView3.ColumnCount = dataGridView2.ColumnCount;
                    double[,] mas3 = new double[n2, m];

                    for (int j = 0; j < m; j++)
                    {
                        for (int k = 0; k < n2; k++)
                        {
                            double s = 0;
                            for (int t = 0; t < m2; t++)
                            {
                                s = s + mas1[t, j] * mas2[k, t];
                            }
                            mas3[k, j] = s;
                            dataGridView3[k, j].Value = mas3[k, j].ToString();

                        }
                    }
                }
            }
                
            

            
            
        }
    }
}
