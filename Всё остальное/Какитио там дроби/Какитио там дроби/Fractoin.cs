using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Какитио_там_дроби
{
    class Fractoin
    {
      public  int sign, integer, numerator, denominator;

        public Fractoin(int n_sign, int n_integer, int n_numerator, int n_denominator)//конструктор класса 
        {
            sign = n_sign;
            integer = n_integer;
            numerator = n_numerator;
            denominator = n_denominator;

        }
        private int NOD(int A, int B)
        {
            while (A != B)
            {
                if (A > B)
                {
                    A = A - B;
                }
                else
                {
                    B = B - A;
                }
            }
            return A;
        }
        
        public void Reduction()//сокращение дроби 
        {
            int k = NOD(numerator, denominator);
            if (k != 1)
            {
                numerator = numerator / k;
                denominator = denominator / k;
            }
        }

        public void Incorrect_fraction()// привидение в неправильную дорбь 
        {
            numerator = integer * denominator + numerator;
            integer = 0;
        }

        public void Correct_fraction()// создание правильной дроби и выделение целой части 
        {
            int k = integer;
            integer = numerator / denominator;
            numerator = numerator = integer * denominator;
            integer = integer + k;
        }

        public void Addition(Fractoin d)// сложение дробей 
        {
            integer = sign * integer + d.sign * d.integer;
            int k1 = sign * numerator * d.denominator + d.sign * d.numerator * denominator;
            denominator = denominator * d.denominator;
            numerator = k1;
            if (integer < 0)
            {
                integer = integer * (-1);
                sign = -1;
            }

        }
        
        // Вычитание, умножение деление дописать.
    }
}
