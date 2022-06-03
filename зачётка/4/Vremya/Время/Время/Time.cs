using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Время
{
    public class Time
    {
        public int hour, minutes, seconds;

        public Time (int n_hour,int n_minutes, int n_seconds)
        {
            hour = n_hour;
            minutes = n_minutes;
            seconds = n_seconds;
        }
     
        public Time()
        {
            hour = 1;
            minutes = 0;
            seconds = 0;
        }
        
        public void ToSeconds()
        {
            minutes = minutes + hour * 60;
            hour = 0;
            seconds = seconds + minutes * 60;
            minutes = 0;
        }
        public void Addition(Time d) //Сложение времени
        {
            d.ToSeconds();
            ToSeconds();
            int s = Math.Abs(d.seconds + seconds);
            minutes = s / 60;
            seconds = s % 60;
            hour = minutes / 60;
            minutes = minutes % 60;
        }
        public void Subtraction(Time d) //Вычитание времени
        {
            d.ToSeconds();
            ToSeconds();
            int s = Math.Abs(d.seconds - seconds);
            minutes = s / 60;
            seconds = s % 60;
            hour = minutes / 60;
            minutes = minutes % 60;
        }
        public static Time operator +(Time b1, Time b2)
        {
            Time b = new Time();
            b2.ToSeconds();
            b1.ToSeconds();
            int s = Math.Abs(b2.seconds + b1.seconds);
            b.minutes = s / 60;
            b.seconds = s % 60;
            b.hour = b.minutes / 60;
            b.minutes = b.minutes % 60;
            return b;
        }
        public static Time operator -(Time b1, Time b2)
        {
            Time b = new Time();
            b2.ToSeconds();
            b1.ToSeconds();
            int s = Math.Abs(b2.seconds - b1.seconds);
            b.minutes = s / 60;
            b.seconds = s % 60;
            b.hour = b.minutes / 60;
            b.minutes = b.minutes % 60;
            return b;
        }

        public static bool operator >=(Time b1, Time b2)
        {
          
            int k1 = b1.hour * b1.minutes * b1.seconds;
            int k2 = b2.hour * b2.minutes * b2.seconds;
            if (k1 >= k2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <=(Time b1, Time b2)
        {

            int k1 = b1.hour * b1.minutes * b1.seconds;
            int k2 = b2.hour * b2.minutes * b2.seconds;
            if (k1 <= k2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(Time b1, Time b2)
        {

            int k1 = b1.hour * b1.minutes * b1.seconds;
            int k2 = b2.hour * b2.minutes * b2.seconds;
            if (k1 < k2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >(Time b1, Time b2)
        {

            int k1 = b1.hour * b1.minutes * b1.seconds;
            int k2 = b2.hour * b2.minutes * b2.seconds;
            if (k1 > k2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator ==(Time b1, Time b2)
        {

            int k1 = b1.hour * b1.minutes * b1.seconds;
            int k2 = b2.hour * b2.minutes * b2.seconds;
            if (k1 == k2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Time b1, Time b2)
        {
            int k1 = b1.hour * b1.minutes * b1.seconds;
            int k2 = b2.hour * b2.minutes * b2.seconds;
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
            s = s + ":" + minutes + ":" + seconds;
            return s;
        }
        public static Time Parse(string str)
        {
            Time f = new Time();
            int l = str.Length;
            int n = str.IndexOf(":");
            int m = str.LastIndexOf(":");
            f.hour = Convert.ToInt32(str.Substring(0, n));
            f.minutes = Convert.ToInt32(str.Substring(n + 1, l - m - 1));
            f.seconds = Convert.ToInt32(str.Substring(m + 1, l - m - 1));
            
           
            
            return f;
        }

    }
}
