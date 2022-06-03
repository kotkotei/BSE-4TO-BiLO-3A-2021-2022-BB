using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR6._2022
{
    class Cube:Parents
    {
        public Cube(double new_x) : base(new_x) { }

        public override double S()
        {
            double s = Math.Pow(x, 2);
            return s;
        }
        public override string ToString()
        {
            return "Куб x=" + x;
        }
    }
}
