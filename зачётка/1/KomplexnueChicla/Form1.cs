using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace KomplexnueChicla
{
    public partial class Form1 : Form
    {
        Komplex f, f2;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            domainUpDown1.SelectedIndex = 0;
            domainUpDown2.SelectedIndex = 0;
            domainUpDown3.SelectedIndex = 0;
            domainUpDown4.SelectedIndex = 0;
            domainUpDown5.SelectedIndex = 0;
            domainUpDown6.SelectedIndex = 0;
        }
        public void Print(Komplex f)
        {

            if (f.sign > 0)
            {
                domainUpDown3.SelectedIndex = 0;
            }
            else
            {
                domainUpDown3.SelectedIndex = 1;
            }
            if (f.sign_i > 0)
            {
                domainUpDown6.SelectedIndex = 0;
            }
            else
            {
                domainUpDown6.SelectedIndex = 1;
            }
            textBox5.Text = f.vechestv.ToString();
            textBox6.Text = f.mnimoe.ToString();
            
        }
        public Komplex ReceiveF()
        {
            int sign = 1;
            if (domainUpDown1.SelectedIndex == 0)
            {
                sign = 1;
            }
            else if (domainUpDown1.SelectedIndex == 1)
            {
                sign = -1;
            }

            int sign_i = 1;
            if (domainUpDown4.SelectedIndex == 0)
            {
                sign_i = 1;
            }
            else if (domainUpDown4.SelectedIndex == 1)
            {
                sign_i = -1;
            }
            int vechestv = Convert.ToInt32(textBox1.Text);
            int mnimoe = Convert.ToInt32(textBox2.Text);
            

            Komplex newf = new Komplex(vechestv, sign, mnimoe, sign_i);
            return newf;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Komplex f = ReceiveF();
            Komplex f2 = ReceiveF2();
            f.Addition(f2);
            Print(f);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Komplex f = ReceiveF();
            Komplex f2 = ReceiveF2();
            f.Subtraction(f2);
            Print(f);
        }

        public Komplex ReceiveF2()
        {
            int sign2 = 1;
            if (domainUpDown2.SelectedIndex == 0)
            {
                sign2 = 1;
            }
            else if (domainUpDown2.SelectedIndex == 1)
            {
                sign2 = -1;
            }


            int sign_i = 1;
            if (domainUpDown5.SelectedIndex == 0)
            {
                sign_i = 1;
            }
            else if (domainUpDown5.SelectedIndex == 1)
            {
                sign_i = -1;
            }
            int vechestv2 = Convert.ToInt32(textBox3.Text);
            int mnimoe2 = Convert.ToInt32(textBox4.Text);
            

            Komplex newf2 = new Komplex( vechestv2, sign2, mnimoe2, sign_i);
            return newf2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Komplex f = ReceiveF();
            Komplex f2 = ReceiveF2();
            if (f >= f2)
            {
                MessageBox.Show("Верно");
            }
            else
            {
                MessageBox.Show("Неверно");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Komplex f = ReceiveF();
            Komplex f2 = ReceiveF2();
            if (f < f2)
            {
                MessageBox.Show("Верно");
            }
            else
            {
                MessageBox.Show("Неверно");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Komplex f = ReceiveF();
            Komplex f2 = ReceiveF2();
            if (f > f2)
            {
                MessageBox.Show("Верно");
            }
            else
            {
                MessageBox.Show("Неверно");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Komplex f = ReceiveF();
            Komplex f2 = ReceiveF2();
            if (f == f2)
            {
                MessageBox.Show("Верно");
            }
            else
            {
                MessageBox.Show("Неверно");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Komplex f = ReceiveF();
            Komplex f2 = ReceiveF2();
            if (f != f2)
            {
                MessageBox.Show("Верно");
            }
            else
            {
                MessageBox.Show("Неверно");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Komplex f = ReceiveF();
            textBox7.Text = f.ToString();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            string s = textBox7.Text;
            Komplex ff = Komplex.Parse(s);
            Print(ff);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Komplex f = ReceiveF();
            Komplex f2 = ReceiveF2();
            if (f <= f2)
            {
                MessageBox.Show("Верно");
            }
            else
            {
                MessageBox.Show("Неверно");
            }

        }







    }
}
