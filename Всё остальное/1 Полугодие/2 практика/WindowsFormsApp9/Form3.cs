using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pas = "3454";
            if (textBox1.Text == pas)
                MessageBox.Show("Молодец");

            else
            {
                if (textBox1.Text != pas)
                    MessageBox.Show("попобуй снова");
            }
            


        }
    }
}
