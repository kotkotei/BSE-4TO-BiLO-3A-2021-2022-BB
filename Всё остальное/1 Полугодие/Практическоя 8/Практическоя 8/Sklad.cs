using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическоя_8
{
    class Sklad
    {
        public string info;
        public double obiom;
        public int stoimist;


        public override string ToString()
        {
            return info + " Стоимость=" + stoimist + " Объём=" + obiom;
        }
    }
}
