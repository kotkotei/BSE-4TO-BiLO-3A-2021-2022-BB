using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Корзина
{
    public class ParentClass
    {
        public Color color;
        public List<Mypoint> body = new List<Mypoint>();

        public ParentClass(Color n_color)
        {
            color = n_color;
        }
        public void Add(Mypoint p)
        {
            body.Add(p);
        }
    }
}
