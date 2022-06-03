using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_практика_ресуем_квадрат
{
    class Class1
    {
        int x, y, h;
        PictureBox myPB;
        public Class1(int n_x, int n_y, int n_h, PictureBox n_myPB)
        {
            x = n_x;
            y = n_y;
            h = n_h;
            myPB = n_myPB;
        }
        public void Draw()
        {
            //myPB.Image = new Bitmap(myPB.Width, myPB.Height);
            Graphics g = Graphics.FromImage(myPB.Image);
           // myPB.BackColor = Color.White;

            Pen p = new Pen(Color.Red, 5);
            SolidBrush b = new SolidBrush(Color.Aquamarine);
            /*int x = Convert.ToInt32(numericUpDown1.Value);
            int y = Convert.ToInt32(numericUpDown2.Value);
            int h = Convert.ToInt32(numericUpDown3.Value);*/
            g.FillRectangle(b, x, y, h, h);
            g.DrawRectangle(p, x, y, h, h);
            Point p1 = new Point(x + h / 1, y);
            Point p2 = new Point(x + h / 40, y + h);
            g.DrawLine(p, p1, p2);
            Point p3 = new Point(x, y + h / 40);
            Point p4 = new Point(x + h, y + h * 1);
            g.DrawLine(p, p3, p4);
            SolidBrush bs2 = new SolidBrush(Color.Green);
            g.FillEllipse(bs2, x + h / 3, y + h / 4 + h / 2, h / 2 - h / 6 - h / 6, h / 2 - h / 5 - h / 13);
            g.FillEllipse(bs2, x + h / 4 + h / 8, y + h / 8, h / 2 - h / 8 - h / 8, h / 2 - h / 8 - h / 8);
            myPB.Refresh();
        }



    }
}
