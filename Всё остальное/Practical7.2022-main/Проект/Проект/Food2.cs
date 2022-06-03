using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проект
{
    public class Food2:ParentClass
    {
        public Food2(Color n_color) : base(n_color)
        {

        }
        public void Delete() //удаление еды с экрана
        {

        }
        public MyPoint RandomFood(int sx, int sy)// Случайное появление еды 
        {
            Random r = new Random();
            MyPoint a = new MyPoint(r.Next(0, sx), 0);
            return a;
        }
        public void Move()
        {
            for (int i = 0; i < body.Count; i++)
            {

                body[i].y = body[i].y + 1;
            }
        }
    }
}
