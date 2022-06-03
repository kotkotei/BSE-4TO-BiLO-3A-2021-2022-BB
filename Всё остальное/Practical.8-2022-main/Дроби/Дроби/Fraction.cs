using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дроби
{
    class Fraction
    {
        public int sign, integer, numeration, denominator;

        public Fraction(int n_sign, int n_integer, int n_numeration, int n_denominator)//конструктор класса
        {
            sign = n_sign;
            integer = n_integer;
            numeration = n_numeration;
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
        public void Reduction()// Сокращение дроби
        {
            int k = NOD(numeration, denominator);
            if (k != 1)
            {
                numeration = numeration / k;
                denominator = denominator / k;
            }
        }
        public void Incorrect_fraction()// приведение в неправильную дробь 
        {
            numeration = integer * denominator + numeration;
            integer = 0;
        }
        public void Correct_fraction()//Создание правильной дроби и выделение целой части 
        {
            int k = integer;
            integer = numeration / denominator;
            numeration = numeration - integer * denominator;
            integer = integer + k;
        }
        public void Addition(Fraction d)//Сложение дробей 
        {
            integer = sign * integer + d.sign * d.integer;
            int k1 = sign * numeration * d.denominator + d.sign * d.numeration * denominator;
            denominator = denominator * d.denominator;
            numeration = k1;
            if (integer < 0)
            {
                integer = integer * (-1);
                sign = -1;
            }
        }
        public void Addition2(Fraction d)
        {

        }
        public void Subtrachion(Fraction d)//Вычитание дробей
        {
            Incorrect_fraction();
            d.Incorrect_fraction();
            int k1 = (sign * numeration) * d.denominator - (d.sign * (d.numeration)) * denominator;
            numeration = k1;
            denominator = d.denominator * denominator;
            if (numeration < 0)
            {
                numeration = numeration * (-1);
                sign = sign * (-1);
            }
            Correct_fraction();
            Reduction();
        }
        public void Multiplication(Fraction d)//Умножение дробей
        {
            Incorrect_fraction();
            d.Incorrect_fraction();
            int t = sign * numeration * d.sign * d.numeration;
            int t2 = denominator * d.denominator;
            numeration = t;
            denominator = t2;
            if (numeration < 0)
            {
                numeration = numeration * (-1);
                sign = -1;
            }
            else
            {
                sign = 1;
            }
            Correct_fraction();
            Reduction();

        }
        public void Division(Fraction d)//Деление дробей
        {
            Incorrect_fraction();
            d.Incorrect_fraction();
            int t = sign * numeration * d.sign * d.denominator;
            int t2 = d.numeration * denominator;
            numeration = t;
            denominator = t2;
            if (numeration < 0)
            {
                numeration = numeration * (-1);
                sign = -1;
            }
            else
            {
                sign = 1;
            }
            Correct_fraction();
            Reduction();
        }
    }
}
