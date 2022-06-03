using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR5._2022
{
    class Cl : Parents
    {
       
        public double y;

        public Cl(double new_x, double new_y) : base(new_x)
        {
            
            y = new_y;
            

        }
        public override double S()
        {
            double s = Math.PI * Math.Pow(x, 2) * y;
            return s;
        }
        public override string ToString()
        {
            return "Цилиндр x=" + x+" y="+y;
        }


    }
}
