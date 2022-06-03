using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Время
{
    public class Money
    {
        public int dollars, cent;

        public Money(int n_dollars, int n_cent)
        {
            dollars = n_dollars;
            cent = n_cent;
        }

        public Money()
        {
            dollars = 1;
            cent = 0;
        }
        public void ToCent()
        {
            cent += dollars * 100;
            dollars = 0;
        }
        public void Addition(Money d) //Сложение времени
        {
            d.ToCent();
            ToCent();
            int s = Math.Abs(d.cent + cent);
           
            dollars = cent / 100;
            cent = cent - dollars *100;
            
        }
        public void Subtraction(Money d) //Вычитание времени
        {
            d.ToCent();
            ToCent();
            int s = Math.Abs(d.cent - cent);
            dollars = cent / 100;
            cent = cent - dollars * 100;
        }
        public static Money operator +(Money b1, Money b2)
        {
            Money b = new Money();
            b1.ToCent();
            b2.ToCent();
            int s = Math.Abs(b1.cent + b2.cent);

            b.dollars = s / 100;
            b.cent = s - b.dollars * 100;
            return b;
        }
        public static Money operator -(Money b1, Money b2)
        {
            Money b = new Money();
            b1.ToCent();
            b2.ToCent();
            int s = Math.Abs(b1.cent - b2.dollars);

            b.dollars = s / 100;
            b.cent = s - b.dollars * 100;
            return b;
        }

        public static bool operator >=(Money b1, Money b2)
        {
          
            int k1 = b1.dollars * b1.cent;
            int k2 = b2.dollars * b2.cent;
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

            int k1 = b1.dollars * b1.cent;
            int k2 = b2.dollars * b2.cent;
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

            int k1 = b1.dollars * b1.cent;
            int k2 = b2.dollars * b2.cent;
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

            int k1 = b1.dollars * b1.cent;
            int k2 = b2.dollars * b2.cent;
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

            int k1 = b1.dollars * b1.cent;
            int k2 = b2.dollars * b2.cent;
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
            int k1 = b1.dollars * b1.cent;
            int k2 = b2.dollars * b2.cent;
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
           
            if (dollars != 0)
            {
                s = s + cent.ToString();
            }
            s = s + " : " + dollars + " : ";
            return s;
        }
        public static Money Parse(string str)
        {
            Money f = new Money();

            int l = str.Length;
            int n = str.IndexOf(":");
            int m = str.LastIndexOf(":");
            f.dollars = Convert.ToInt32(str.Substring(0, n));
            f.cent = Convert.ToInt32(str.Substring(n+1, l-m-1));
            return f;
        }
    }
}
