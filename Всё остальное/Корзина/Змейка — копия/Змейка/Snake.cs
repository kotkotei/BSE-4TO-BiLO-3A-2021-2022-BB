using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Змейка
{
   public class Snake:ParentClass
    {
        public int speed = 1;
        public Snake(Color n_color):base(n_color)
        {
            // color = n_color;
        }
       
        public void Move(int dx, int dy)//Движение  SNAKE
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
}
