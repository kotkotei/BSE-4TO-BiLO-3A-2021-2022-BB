using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Проект
{
    public class ParentClass
    {
        public Color color;
        public List<MyPoint> body = new List<MyPoint>();

        public ParentClass(Color n_color)
        {
            color = n_color;
        }
        public void Add(MyPoint p)
        {
            body.Add(p);
        }
    }
}
