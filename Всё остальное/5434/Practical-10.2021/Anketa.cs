using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_10._2021
{
    class Anketa
    {
        public string FIO;
        public int school;
        public int klass;
        public int test;

        public override string ToString()
        {
            return " ФИО " + FIO + " school №" + school + " klass=" + klass + " test=" + test;
        }
    }
}
