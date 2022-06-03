using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR6._2022
{
    class Tuba:Parents
    {
        public double r1;
        public double r2;

        public Tuba(double new_x, double new_r1, double new_r2) : base(new_x)
        {

            r1 = new_r1;
            r2 = new_r1;

        }
        public override double S()
        {
            double s = Math.PI * ((r1 * r1) - (r2 * r2)) * x;
            return s;
        }
        public override string ToString()
        {
            return "Туба r1" + r1 + " r2=" + r2 + " x=" + x;
        }
    }
}
