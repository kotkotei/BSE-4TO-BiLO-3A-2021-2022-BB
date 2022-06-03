using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary5
{
    public class Data
    {
        public int hour, days, years;

        public Data(int n_hour, int n_days, int n_years)
        {
            hour = n_hour;
            days = n_days;
            years = n_years;
        }

        public Data()
        {
            hour = 1;
            days = 0;
            years = 0;
        }

        public void ToHour()
        {
            hour = years * 365 * 24 + days * 24 + hour;
            days = 0;
            years = 0;

        }
        public void ToYHD()
        {

            years = hour / 24 / 365;
            hour = hour - years * 365 * 24;
            days = hour / 24;
            hour = hour - days * 24;

        }
        public void Addition(Data d) //Сложение времени
        {
            d.ToHour();
            ToHour();
            hour = hour + d.hour;
            ToYHD();

        }
        public void Subtraction(Data d) //Вычитание времени
        {
            d.ToHour();
            ToHour();
            hour = hour - d.hour;
            ToYHD();
        }
        public static Data operator +(Data b1, Data b2)
        {
            Data b = new Data();
            b2.ToHour();
            b1.ToHour();
            b.hour = b2.hour + b1.hour;
            return b;
        }
        public static Data operator -(Data b1, Data b2)
        {
            Data b = new Data();
            b2.ToHour();
            b1.ToHour();
            b.hour = b2.hour - b1.hour;
            return b;
        }

        public static bool operator >=(Data b1, Data b2)
        {

            int k1 = b1.hour * b1.days * b1.years;
            int k2 = b2.hour * b2.days * b2.years;
            if (k1 >= k2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <=(Data b1, Data b2)
        {

            int k1 = b1.hour * b1.days * b1.years;
            int k2 = b2.hour * b2.days * b2.years;
            if (k1 <= k2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(Data b1, Data b2)
        {

            int k1 = b1.hour * b1.days * b1.years;
            int k2 = b2.hour * b2.days * b2.years;
            if (k1 < k2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >(Data b1, Data b2)
        {

            int k1 = b1.hour * b1.days * b1.years;
            int k2 = b2.hour * b2.days * b2.years;
            if (k1 > k2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator ==(Data b1, Data b2)
        {

            int k1 = b1.hour * b1.days * b1.years;
            int k2 = b2.hour * b2.days * b2.years;
            if (k1 == k2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Data b1, Data b2)
        {
            int k1 = b1.hour * b1.days * b1.years;
            int k2 = b2.hour * b2.days * b2.years;
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

            if (hour != 0)
            {
                s = s + hour.ToString();
            }
            s = s + ":" + days + ":" + years;
            return s;
        }
        public static Data Parse(string str)
        {
            Data f = new Data();
            int l = str.Length;
            int n = str.IndexOf(":");
            int m = str.LastIndexOf(":");
            f.hour = Convert.ToInt32(str.Substring(0, n));
            f.days = Convert.ToInt32(str.Substring(n + 1, l - m - 1));
            f.years = Convert.ToInt32(str.Substring(m + 1, l - m - 1));



            return f;
        }

    }
}
