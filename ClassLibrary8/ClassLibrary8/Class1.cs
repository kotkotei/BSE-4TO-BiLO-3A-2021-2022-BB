using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary8
{
    public class Data
    {
        public int METR, SANTOMETR, MM;

        public Data(int n_METR, int n_SANTIMETR, int n_MM)
        {
            METR = n_METR;
            SANTOMETR = n_SANTIMETR;
            MM = n_MM;
        }

        public Data()
        {
            METR = 1;
            SANTOMETR = 0;
            MM = 0;
        }

        public void ToHour()
        {
            METR = METR / 1000 + METR % 1000 / 10 + METR % 10;
            SANTOMETR = 0;
            MM = 0;

        }
        public void ToYHD()
        {

            MM = METR / 1000 / 10;
            METR = METR - MM * 1000 * 10;
            SANTOMETR = METR / 10;
            METR = METR - SANTOMETR * 1000;

        }
        public void Addition(Data d) //Сложение времени
        {
            d.ToHour();
            ToHour();
            METR = METR + d.METR;
            ToYHD();

        }
        public void Subtraction(Data d) //Вычитание времени
        {
            d.ToHour();
            ToHour();
            METR = METR - d.METR;
            ToYHD();
        }
        public static Data operator +(Data b1, Data b2)
        {
            Data b = new Data();
            b2.ToHour();
            b1.ToHour();
            b.METR = b2.METR + b1.METR;
            return b;
        }
        public static Data operator -(Data b1, Data b2)
        {
            Data b = new Data();
            b2.ToHour();
            b1.ToHour();
            b.METR = b2.METR - b1.METR;
            return b;
        }

        public static bool operator >=(Data b1, Data b2)
        {

            int k1 = b1.METR * b1.SANTOMETR * b1.MM;
            int k2 = b2.METR * b2.SANTOMETR * b2.MM;
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

            int k1 = b1.METR * b1.SANTOMETR * b1.MM;
            int k2 = b2.METR * b2.SANTOMETR * b2.MM;
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

            int k1 = b1.METR * b1.SANTOMETR * b1.MM;
            int k2 = b2.METR * b2.SANTOMETR * b2.MM;
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

            int k1 = b1.METR * b1.SANTOMETR * b1.MM;
            int k2 = b2.METR * b2.SANTOMETR * b2.MM;
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

            int k1 = b1.METR * b1.SANTOMETR * b1.MM;
            int k2 = b2.METR * b2.SANTOMETR * b2.MM;
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
            int k1 = b1.METR * b1.SANTOMETR * b1.MM;
            int k2 = b2.METR * b2.SANTOMETR * b2.MM;
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

            if (METR != 0)
            {
                s = s + METR.ToString();
            }
            s = s + ":" + SANTOMETR + ":" + MM;
            return s;
        }
        public static Data Parse(string str)
        {
            Data f = new Data();
            int l = str.Length;
            int n = str.IndexOf(":");
            int m = str.LastIndexOf(":");
            f.METR = Convert.ToInt32(str.Substring(0, n));
            f.SANTOMETR = Convert.ToInt32(str.Substring(n + 1, l - m - 1));
            f.MM = Convert.ToInt32(str.Substring(m + 1, l - m - 1));



            return f;
        }

    }
}
