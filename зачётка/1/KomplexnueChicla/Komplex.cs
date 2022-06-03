using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomplexnueChicla
{
    public class Komplex
    {
        public int vechestv, sign, mnimoe, sign_i;
        public Komplex(int n_vechestv, int n_sign, int n_mnimoe, int n_sign_i)
        {
            vechestv = n_vechestv;
            sign = n_sign;
            sign_i = n_sign_i;
            mnimoe = n_mnimoe;

        }
        public Komplex()
        {
            vechestv = 0;
            sign = 1;
            mnimoe = 0;
            sign_i = 1;


        }
        public void Addition(Komplex d) //Сложение комплексных чисел
        {
            vechestv = sign * vechestv + d.sign * d.vechestv;
            mnimoe = sign_i * mnimoe + d.sign_i * d.mnimoe;
            if (vechestv < 0)
            {
                sign = -1;
                vechestv = vechestv * (-1);
            }
            else
            {
                sign = 1;
            }
            if (mnimoe < 0)
            {
                sign_i = -1;
                mnimoe = mnimoe * (-1);

            }
            else
            {
                sign_i = 1;
            }
        }
        public void Subtraction(Komplex d)//Вычитание комплексных чисел 
        {
            vechestv = sign * vechestv - d.sign * d.vechestv;
            mnimoe = sign_i * mnimoe - d.sign_i * d.mnimoe;
            if (vechestv < 0)
            {
                sign = -1;
                vechestv = vechestv * (-1);
            }
            else
            {
                sign = 1;
            }
            if (mnimoe < 0)
            {
                sign_i = -1;
                mnimoe = mnimoe * (-1);

            }
            else
            {
                sign_i = 1;
            }
        }
        public static bool operator <=(Komplex b1, Komplex b2)
        {

            double k1 = Math.Sqrt(b1.vechestv * b1.vechestv + b1.mnimoe * b1.mnimoe);
            double k2 = Math.Sqrt(b2.vechestv * b2.vechestv + b2.mnimoe * b2.mnimoe);
            if (k1 <= k2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >=(Komplex b1, Komplex b2)
        {
            double k1 = Math.Sqrt(b1.vechestv * b1.vechestv + b1.mnimoe * b1.mnimoe);
            double k2 = Math.Sqrt(b2.vechestv * b2.vechestv + b2.mnimoe * b2.mnimoe);
            if (k1 >= k2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool operator <(Komplex b1, Komplex b2)
        {
            double k1 = Math.Sqrt(b1.vechestv * b1.vechestv + b1.mnimoe * b1.mnimoe);
            double k2 = Math.Sqrt(b2.vechestv * b2.vechestv + b2.mnimoe * b2.mnimoe);
            if (k1 < k2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool operator >(Komplex b1, Komplex b2)
        {
            double k1 = Math.Sqrt(b1.vechestv * b1.vechestv + b1.mnimoe * b1.mnimoe);
            double k2 = Math.Sqrt(b2.vechestv * b2.vechestv + b2.mnimoe * b2.mnimoe);
            if (k1 > k2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool operator ==(Komplex b1, Komplex b2)
        {
            double k1 = Math.Sqrt(b1.vechestv * b1.vechestv + b1.mnimoe * b1.mnimoe);
            double k2 = Math.Sqrt(b2.vechestv * b2.vechestv + b2.mnimoe * b2.mnimoe);
            if (k1 == k2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool operator !=(Komplex b1, Komplex b2)
        {
            double k1 = Math.Sqrt(b1.vechestv * b1.vechestv + b1.mnimoe * b1.mnimoe);
            double k2 = Math.Sqrt(b2.vechestv * b2.vechestv + b2.mnimoe * b2.mnimoe);
            if (k1 != k2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public override string ToString()
        {
            string s = "";

            if (vechestv != 0)
            {
                s = s + vechestv.ToString();
            }
            s = s + ":" + mnimoe+ ":";
            return s;
        }
        public static Komplex Parse(string str)
        {
            Komplex f = new Komplex();
            int l = str.Length;
            int n = str.IndexOf(":");
            int m = str.LastIndexOf(":");
            f.vechestv = Convert.ToInt32(str.Substring(0, n));
            f.mnimoe = Convert.ToInt32(str.Substring(n + 1, l - m - 1));




            return f;

        }
    }    
}