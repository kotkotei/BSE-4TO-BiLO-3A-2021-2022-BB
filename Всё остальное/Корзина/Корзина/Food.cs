using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Корзина
{
    class Food : ParentClass
    {
        public Food(Color n_color) : base(n_color)//удаление еды
        {

        }
        public void Delete(int t)
        {
            body.RemoveAt(t);
        }
        public Mypoint RandomFood(int sx, int sy)//Появление еды 
        {
            Random r = new Random();
            Mypoint a = new Mypoint(r.Next(0, sx), r.Next(0, sy));
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
