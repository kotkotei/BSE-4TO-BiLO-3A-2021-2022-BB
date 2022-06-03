using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Money
    {
        public int ruble, kopeika;

        public Money(int n_ruble, int n_kopeika)
        {
            ruble = n_ruble;
            kopeika = n_kopeika;
        }

        public Money()
        {
            ruble = 1;
            kopeika = 0;
        }
        public void ToKopeika()
        {
            kopeika += ruble * 100;
            ruble = 0;
        }
        public void Addition(Money d) //Сложение времени
        {
            d.ToKopeika();
            ToKopeika();
            int s = Math.Abs(d.kopeika + kopeika);

            ruble = kopeika / 100;
            kopeika = kopeika - ruble * 100;

        }
        public void Subtraction(Money d) //Вычитание времени
        {
            d.ToKopeika();
            ToKopeika();
            int s = Math.Abs(d.kopeika - kopeika);
            ruble = kopeika / 100;
            kopeika = kopeika - ruble * 100;
        }
        public static Money operator +(Money b1, Money b2)
        {
            Money b = new Money();
            b1.ToKopeika();
            b2.ToKopeika();
            int s = Math.Abs(b1.kopeika + b2.kopeika);

            b.ruble = s / 100;
            b.kopeika = s - b.ruble * 100;
            return b;
        }
        public static Money operator -(Money b1, Money b2)
        {
            Money b = new Money();
            b1.ToKopeika();
            b2.ToKopeika();
            int s = Math.Abs(b1.kopeika - b2.kopeika);

            b.ruble = s / 100;
            b.kopeika = s - b.ruble * 100;
            return b;
        }

        public static bool operator >=(Money b1, Money b2)
        {

            int k1 = b1.ruble * b1.kopeika;
            int k2 = b2.ruble * b2.kopeika;
            if (k1 >= k2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <=(Money b1, Money b2)
        {

            int k1 = b1.ruble * b1.kopeika;
            int k2 = b2.ruble * b2.kopeika;
            if (k1 <= k2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(Money b1, Money b2)
        {

            int k1 = b1.ruble * b1.kopeika;
            int k2 = b2.ruble * b2.kopeika;
            if (k1 < k2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >(Money b1, Money b2)
        {

            int k1 = b1.ruble * b1.kopeika;
            int k2 = b2.ruble * b2.kopeika;
            if (k1 > k2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator ==(Money b1, Money b2)
        {

            int k1 = b1.ruble * b1.kopeika;
            int k2 = b2.ruble * b2.kopeika;
            if (k1 == k2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Money b1, Money b2)
        {
            int k1 = b1.ruble * b1.kopeika;
            int k2 = b2.ruble * b2.kopeika;
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

            if (ruble != 0)
            {
                s = s + ruble.ToString();
            }
            s = s + " : " + kopeika + " : ";
            return s;
        }
        public static Money Parse(string str)
        {
            Money f = new Money();

            int l = str.Length;
            int n = str.IndexOf(":");
            int m = str.LastIndexOf(":");
            f.ruble = Convert.ToInt32(str.Substring(0, n));
            f.kopeika = Convert.ToInt32(str.Substring(n + 1, l - m - 1));
            return f;
        }
    }
}
