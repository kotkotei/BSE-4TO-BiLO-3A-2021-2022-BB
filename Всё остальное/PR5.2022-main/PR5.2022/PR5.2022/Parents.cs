using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR5._2022
{
    abstract class Parents
    {
        public double x;

        public Parents(double new_x)
        {
            x = new_x;
        }
        abstract public double S();
    }
}
