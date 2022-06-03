using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace практическоя_9
{
    class sklad
    {
        public string poroda;
        public int dlinahersti;
        public int sredniirost;
        public double sredniives;


        public override string ToString()
        {
            return " poroda "  +  poroda  +   " Длина шерсти " +  dlinahersti  +   " Среднии рост "  +  sredniirost  +   " среднии вес "  +   sredniives;
        }


    }
}
