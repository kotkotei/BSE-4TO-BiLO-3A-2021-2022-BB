using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14._01._22
{
    class Figure
    {
        public int x, y, h;
        PictureBox myPb;
        public Figure(int n_x, int n_y, int n_h, PictureBox n_myPb)
        {
            x = n_x;
            y = n_y;
            h = n_h;
            myPb = n_myPb;
        }
        public void Draw()
        {
            
            Graphics g = Graphics.FromImage(myPb.Image);
         
            Pen p = new Pen(Color.Red);
            p.Width = 3;

            SolidBrush b = new SolidBrush(Color.CadetBlue);
           
            g.FillRectangle(b, x, y, h, h);
            g.DrawRectangle(p, x, y, h, h);

            Point p1 = new Point(x, y);
            Point p2 = new Point(x + h, y + h);
            g.DrawLine(p, p1, p2);
            Point p3 = new Point(x, y + h);
            Point p4 = new Point(x + h, y);
            g.DrawLine(p, p3, p4);
            SolidBrush bs2 = new SolidBrush(Color.Green);
            g.FillEllipse(bs2, x + h / 4 + h / 8, y + h / 2 + h / 6, h / 2 - h / 8 - h / 8, h / 2 - h / 8 - h / 8);
            g.FillEllipse(bs2, x + h / 4 + h / 8, y + h / 10, h / 2 - h / 8 - h / 8, h / 2 - h / 8 - h / 8);
            myPb.Refresh();
           
        }
        public override string ToString()
        {
            return "Фигура h=" + h.ToString();
        }
    }
}
