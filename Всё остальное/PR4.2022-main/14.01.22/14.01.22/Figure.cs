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
        public int x, y, h,dx, dy,R,a, da,x0,y0;
        PictureBox myPb;
        Color cl;
        bool t;
        int ds;
        public Figure(int n_x, int n_y, int n_h, PictureBox n_myPb, Color n_cl, bool n_t, int n_s)
        {
            x = n_x;
            y = n_y;
            h = n_h;
            myPb = n_myPb;
            ds = n_s;
            t = n_t;
            cl = n_cl;
            /*dx = 5;
            dy = 5;
            a = 90;
            x0 = myPb.Width / 2 - h / 2;
            y0 = myPb.Height / 2 - h / 2;
            R = myPb.Width / 2 - h / 2;

            x = x0 + Convert.ToInt32(R * Math.Cos(a * Math.PI / 180));
            y = y0 + Convert.ToInt32(R * Math.Cos(a * Math.PI / 180));*/
        }

        /*public Figure(int n_h,PictureBox n_myPb)
        {
            h = n_h;

            myPb = n_myPb;
            dx = 5;
            dy = 5;
            da = 10;
            a = 90;
            x0 = myPb.Width / 2 - h / 2;
            y0 = myPb.Height/ 2 - h / 2;
            R = myPb.Width / 2 - h / 2;
            x = x0 + Convert.ToInt32(R * Math.Cos(a * Math.PI / 180));
            y = y0 + Convert.ToInt32(R * Math.Cos(a * Math.PI / 180));

        }*/



        public void Draw()
        {
            
            Graphics g = Graphics.FromImage(myPb.Image);
         
            Pen p = new Pen(Color.Red);
            p.Width = 3;

            SolidBrush b = new SolidBrush(cl);
           

            g.FillRectangle(b, x, y, h, h);
            g.DrawRectangle(p, x, y, h, h);

            Point p1 = new Point(x+h/2, y);
            Point p2 = new Point(x + h/2, y + h);
            g.DrawLine(p, p1, p2);
            Point p3 = new Point(x, y + h/2);
            Point p4 = new Point(x + h, y+h/2);
            g.DrawLine(p, p3, p4);
            SolidBrush bs2 = new SolidBrush(Color.Green);
            g.FillEllipse(bs2, x + h / 8, y + h / 2 + h / 8, h / 2 - h / 8 - h / 8, h / 2 - h / 8 - h / 8);
            g.FillEllipse(bs2, x + h / 2 + h / 8, y + h / 8, h / 2 - h / 8 - h / 8, h / 2 - h / 8 - h / 8);
            Point p5 = new Point(x, y + h);
            Point p6 = new Point(x + h, y + h);

            Point[] mas = new Point[4];
            mas[0] = p1;
            mas[1] = p5;
            mas[2] = p6;
            mas[3] = p1;
            g.DrawLines(p, mas);

            myPb.Refresh();//!!!!!!!!!!*/
        }
        public void Clear()
        {
            Graphics g = Graphics.FromImage(myPb.Image);
            SolidBrush b = new SolidBrush(Color.White);
            g.FillRectangle(b, x - 5, y - 5, h + 10, h + 10);
            myPb.Refresh();
        }
        public void Move()
        {
            Clear();
            if (t == true)//по X
            {
                int newx = x + ds;
                if (newx > (myPb.Width - h) || newx < 0)
                {
                    ds = -ds;

                }
                x = x + ds;
            }
            else//по y
            {
                int newy = y + ds;
                if (newy > (myPb.Height - h) || newy < 0)
                {
                    ds = -ds;

                }
                y = y + ds;
            }
            
            /*a = a + da;
            if (a > 360)
            {
                a = 0;
            }
            x = x0 + Convert.ToInt32(R * Math.Cos(a * Math.PI / 180));
            y = y0 + Convert.ToInt32(R * Math.Cos(a * Math.PI / 180));*/

            Draw();
        }

        public override string ToString()
        {
            return "Фигура h=" + h.ToString();
        }
    }
}
