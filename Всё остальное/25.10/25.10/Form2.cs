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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                textBox1.Text = "";
                string s = openFileDialog1.FileName;
                FileInfo fileInfo = new FileInfo(s);
                textBox1.Text += "Имя файла" + fileInfo.Name + "\r\n";
                textBox1.Text += "Время создания " + fileInfo.CreationTime + "\r\n";
                textBox1.Text += "Размер" + fileInfo.Length + "\r\n";
                //fileInfo.CopyTo("C:\\"+fileInfo.Name, true); //Копировать 
                fileInfo.CopyTo("C:\\2222\\" + fileInfo.Name);//ТЕХНИКА ПЕРЕМЕЩЕНИЕ 
                //fileInfo.Delete();Техника Delete ez game 
                File.Delete(s);
                //file анологичен FileInfo в части копирование и удаление файла 

            }
        }
    }
}
