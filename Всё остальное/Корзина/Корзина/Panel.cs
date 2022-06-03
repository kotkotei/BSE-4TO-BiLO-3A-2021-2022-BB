using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Корзина
{

    class Panel : ParentClass
    {
        public int speed = 1;

        public Panel(Color n_color) : base(n_color)
        {
            // color = n_color;
        }
        public void AddHvost()//добавление хвоста 
        {
            int n = body.Count - 1;
            if ((body[n].x - body[n - 1].x) == 0)
            {
                body.Add(new Mypoint(body[n].x, body[n].y + 1));
            }
            else
            {
                body.Add(new Mypoint(body[n].x + 1, body[n].y));
            }
        }
        public void Move(int dx, int dy)//Движение  PANEL
        {

            if (dx == -1)
            {
                if (body[0].x - 1 >= 0)
                {



                    for (int i = body.Count - 1; i > 0; i--)
                    {

                        body[i].x = body[i - 1].x;
                        body[i].y = body[i - 1].y;
                    }
                    body[0].x = body[0].x + dx;
                    body[0].y = body[0].y + dy;
                }
            }
            else
            {
                if (body[body.Count - 1].x + 1 < 49) 
                {
                    for (int i = 0; i < body.Count - 1; i++)
                    {

                        body[i].x = body[i + 1].x;
                        body[i].y = body[i + 1].y;
                    }
                    body[body.Count - 1].x = body[body.Count - 1].x + dx;
                    body[body.Count - 1].y = body[body.Count - 1].y + dy;
                }
            }
        }

    }
}

        
    
        
        

    



   