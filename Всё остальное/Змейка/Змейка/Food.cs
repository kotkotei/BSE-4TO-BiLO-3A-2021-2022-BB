using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Змейка
{
    class Food : ParentClass
    {
        public Food(Color n_color) : base(n_color)
        {

        }
        public void Delete(int t)//Удаление еды (Змея их типо ест)
        {
            body.RemoveAt(t);
        }
        public Mypoint RandomFood(int sx, int sy)//Случайное появление еды
        {
            Random r = new Random();
            Mypoint a = new Mypoint(r.Next(0,sx), r.Next(0, sy));
            return a;
        }
    }
}
