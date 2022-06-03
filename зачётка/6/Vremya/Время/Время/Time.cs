using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Время
{
    public class Data
    {
        public int Day, month, year;

        public Data (int n_Day,int n_month, int n_year)
        {
            Day = n_Day;
            month = n_month;
            year = n_year;
        }
     
        public Data()
        {
            Day = 1;
            month = 0;
            year = 0;
        }
        
        public void ToHour()
        {
            Day = year * 32 * 13 + month * 30 + Day;
            month = 0;
            year = 0;
            
        }
        public void ToYHD()
        {
            
            year = Day/30/32;
            Day = Day - year * 32 * 30;
            month = Day /30;
            Day = Day - month * 30;

        }
       public void Addition(Data d) //Сложение времени
        {
            d.ToHour();
            ToHour();
            Day = Day + d.Day;
            ToYHD();

        }
        public void Subtraction(Data d) //Вычитание времени
        {
            d.ToHour();
            ToHour();
            Day = Day - d.Day;
            ToYHD();
        }
        public static Data operator +(Data b1, Data b2)
        {
            Data b = new Data();
            b2.ToHour();
            b1.ToHour();
            b.Day = b2.Day + b1.Day;
            return b;
        }
        public static Data operator -(Data b1, Data b2)
        {
            Data b = new Data();
            b2.ToHour();
            b1.ToHour();
            b.Day = b2.Day - b1.Day;
            return b;
        }

        public static bool operator >=(Data b1, Data b2)
        {

            int k1 = b1.Day * b1.month * b1.year;
            int k2 = b2.Day * b2.month * b2.year;
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

            int k1 = b1.Day * b1.month * b1.year;
            int k2 = b2.Day * b2.month * b2.year;
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

            int k1 = b1.Day * b1.month * b1.year;
            int k2 = b2.Day * b2.month * b2.year;
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

            int k1 = b1.Day * b1.month * b1.year;
            int k2 = b2.Day * b2.month * b2.year;
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

            int k1 = b1.Day * b1.month * b1.year;
            int k2 = b2.Day * b2.month * b2.year;
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
            int k1 = b1.Day * b1.month * b1.year;
            int k2 = b2.Day * b2.month * b2.year;
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
           
            if (Day != 0)
            {
                s = s + Day.ToString();
            }
            s = s + ":" + month + ":" + year;
            return s;
        }
        public static Data Parse(string str)
        {
            Data f = new Data();
            int l = str.Length;
            int n = str.IndexOf(":");
            int m = str.LastIndexOf(":");
            f.Day = Convert.ToInt32(str.Substring(0, n));
            f.month = Convert.ToInt32(str.Substring(n + 1, l - m - 1));
            f.year = Convert.ToInt32(str.Substring(m + 1, l - m - 1));
            
           
            
            return f;
        }

    }
}
