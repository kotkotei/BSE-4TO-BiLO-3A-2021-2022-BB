using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Проект
{
    public class Food:ParentClass
    {
        
            public Food(Color n_color) : base(n_color)
            {

            }
            public void Delete(int t)//удаление еды с экрана
            {
                body.RemoveAt(t);
            }
            public MyPoint RandomFood(int sx, int sy)//случайное появление еды
            {
                Random r = new Random();
                MyPoint a = new MyPoint(r.Next(0, sx), 0);
                return a;
            }
            

       public void Move()
        {
            for (int i = 0; i < body.Count; i++)
            {
                
                body[i].y = body[i].y+1;
            }
       }
        
    }
}
