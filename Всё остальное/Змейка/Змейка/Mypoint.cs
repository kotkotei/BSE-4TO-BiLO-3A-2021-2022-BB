using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Змейка
{
   public class Mypoint //Класс для хранения координат состовляющих элементы игры
    {
        public int x, y;
        public Mypoint(int n_x, int n_y)
        {
            x = n_x;
            y = n_y;
        }
    }
}
