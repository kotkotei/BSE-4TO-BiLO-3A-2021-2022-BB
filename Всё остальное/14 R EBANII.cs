using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            int last_count = 0;
            int num = 13;
            int temp;
            int Largest_Num = 0;
            for (int i = num; i < 1000000; i++)
            {
                temp = i;
                while (temp > 1)
                {
                    if (temp % 2 == 0)
                    {
                        temp /= 2;
                    }
                    else
                    {
                        temp = (3 * temp) + 1;
                    }
                    count++;

                }

                if (last_count < count)
                {
                    last_count = count;
                    Largest_Num = i;
                }

                count = 1;
            }
            Console.WriteLine(last_count);
            Console.WriteLine(Largest_Num);
            Console.ReadKey();
        }
    }
}

