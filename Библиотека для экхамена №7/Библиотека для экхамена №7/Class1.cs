using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Библиотека_для_экхамена__7
{
    public class Rastenia
    {
        public double SAJEN, ARHIN, VERHOK, p, VERSTA;

        public Rastenia(double n_SAJEN, double n_ARHIN, double n_VERHOK, double n_p, double n_VERSTA)
        {
            SAJEN = n_SAJEN;
            ARHIN = n_ARHIN;
            VERHOK = n_VERHOK;
            p = n_p;
            VERSTA = n_VERSTA;
        }

        public Rastenia()
        {
            SAJEN = 3 * ARHIN;
            ARHIN = 16 * VERHOK;
            VERHOK = 44.5;
            VERSTA = 500 * SAJEN;
        }

        public Rastenia(int saJEN, int aRHIN, int vERHOK)
        {
            SAJEN = saJEN;
            ARHIN = aRHIN;
            VERHOK = vERHOK;
        }

        public Rastenia(int saJEN, int aRHIN, int vERHOK, int vERSTA) : this(saJEN, aRHIN, vERHOK)
        {
        }

        public void ToRASTENI()
        {
            SAJEN = ARHIN * VERHOK * 44.5;
            ARHIN = VERHOK * 44.5;
            VERHOK = 44.5;
            VERSTA = SAJEN * ARHIN * VERHOK * 44.5;
        }

        public void Addition(Rastenia d) //Сложение времени
        {
            d.ToRASTENI();
            ToRASTENI();
            double v = VERSTA + (p / VERSTA);
            double s = SAJEN + (p / SAJEN);
            double q = ARHIN + (p / ARHIN);
            double w = VERHOK + (p / VERHOK);


        }
        public void Subtraction(Rastenia d) //Вычитание времени
        {
            d.ToRASTENI();
            ToRASTENI();
            double v = VERSTA - (p / VERSTA);
            double s = SAJEN - (p / SAJEN);
            double q = ARHIN - (p / ARHIN);
            double w = VERHOK - (p / VERHOK);
        }
        public static Rastenia operator +(Rastenia b1, Rastenia b2)
        {
            Rastenia b = new Rastenia();
            b2.ToRASTENI();
            b1.ToRASTENI();
            double v = b2.VERSTA + (b1.p / b1.VERSTA);
            double s = b2.SAJEN + (b1.p / b1.SAJEN);
            double q = b2.ARHIN + (b1.p / b1.ARHIN);
            double w = b2.VERHOK + (b1.p / b1.VERHOK);
            return b;
        }
        public static Rastenia operator -(Rastenia b1, Rastenia b2)
        {
            Rastenia b = new Rastenia();
            b2.ToRASTENI();
            b1.ToRASTENI();
            double v = b2.VERSTA - (b1.p / b1.VERSTA);
            double s = b2.SAJEN - (b1.p / b1.SAJEN);
            double q = b2.ARHIN - (b1.p / b1.ARHIN);
            double w = b2.VERHOK - (b1.p / b1.VERHOK);
            return b;
        }

        public static bool operator >=(Rastenia b1, Rastenia b2)
        {

            double k1 = b1.SAJEN * b1.ARHIN * b1.VERHOK;
            double k2 = b2.SAJEN * b2.ARHIN * b2.VERHOK;
            if (k1 >= k2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <=(Rastenia b1, Rastenia b2)
        {

            double k1 = b1.SAJEN * b1.ARHIN * b1.VERHOK;
            double k2 = b2.SAJEN * b2.ARHIN * b2.VERHOK;
            if (k1 <= k2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(Rastenia b1, Rastenia b2)
        {

            double k1 = b1.SAJEN * b1.ARHIN * b1.VERHOK;
            double k2 = b2.SAJEN * b2.ARHIN * b2.VERHOK;
            if (k1 < k2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >(Rastenia b1, Rastenia b2)
        {

            double k1 = b1.SAJEN * b1.ARHIN * b1.VERHOK;
            double k2 = b2.SAJEN * b2.ARHIN * b2.VERHOK;
            if (k1 > k2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator ==(Rastenia b1, Rastenia b2)
        {

            double k1 = b1.SAJEN * b1.ARHIN * b1.VERHOK;
            double k2 = b2.SAJEN * b2.ARHIN * b2.VERHOK;
            if (k1 == k2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Rastenia b1, Rastenia b2)
        {
            double k1 = b1.SAJEN * b1.ARHIN * b1.VERHOK;
            double k2 = b2.SAJEN * b2.ARHIN * b2.VERHOK;
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

            if (SAJEN != 0)
            {
                s = s + SAJEN.ToString();
            }
            s = s + ":" + ARHIN + ":" + VERHOK;
            return s;
        }
        public static Rastenia Parse(string str)
        {
            Rastenia f = new Rastenia();
            int l = str.Length;
            int n = str.IndexOf(":");
            int m = str.LastIndexOf(":");
            f.SAJEN = Convert.ToInt32(str.Substring(0, n));
            f.ARHIN = Convert.ToInt32(str.Substring(n + 1, l - m - 1));
            f.VERHOK = Convert.ToInt32(str.Substring(m + 1, l - m - 1));



            return f;
        }

    }
}
