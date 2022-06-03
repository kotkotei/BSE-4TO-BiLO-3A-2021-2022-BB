using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp21;

namespace WindowsFormsApp21
{
    public class Fraction
    {
        public int sign, integer, numerator, denominator;

        public Fraction(int n_sign, int n_integer, int n_numerator, int n_denominator)//конструктор класса
        {
            sign =n_sign;
            integer = n_integer;
            numerator = n_numerator;
            denominator = n_denominator;

        }
        public Fraction() {
            sign = 1;
            integer = 0;
            numerator = 0;
            denominator = 1;
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
        public void Reduction()// сокращение дроби
        {
            if (numerator > 0)
            {
                int k = NOD(numerator, denominator);
                if (k != 1)
                {
                    numerator = numerator / k;
                    denominator = denominator / k;
                }
            }
        }

        public void Incorrect_fraction()//приведение в неправильную дробь
        {
            numerator = integer * denominator + numerator;
            integer = 0;
        }

        public void Correct_fraction()//создание правильной дроби и выделение целой части
        {
            int k = integer;
            integer = numerator / denominator;
            numerator = numerator - integer * denominator;
            integer = integer + k;
        }

        public void Addition(Fraction d)//сложение дробей
        {
            integer = sign* integer + d.sign*d.integer;
            int k1 = sign*numerator * d.denominator + d.sign*d.numerator * denominator;
            denominator = denominator * d.denominator;
            numerator = k1;
            if (integer < 0)
            {
                integer = integer * (-1);
                sign = sign * (-1);
            }
        }
        public void Subtraction(Fraction d)//Вычитание дробей
        {
            Incorrect_fraction();
            d.Incorrect_fraction();
            //integer = sign * integer - d.sign * d.integer;
            int k1 = (sign * numerator) * d.denominator - (d.sign * (d.numerator)) * denominator;
            numerator = k1;
            denominator = d.denominator * denominator;
            if (numerator < 0)
            {
                numerator = numerator * (-1);
                sign = sign * (-1);
            }
            Correct_fraction();
            Reduction();
        }


        public void Multiplication(Fraction d)
        {
            Incorrect_fraction();
            d.Incorrect_fraction();
            int t = sign * numerator * d.sign * d.numerator;
            int t2 = denominator * d.denominator;
            numerator = t;
            denominator = t2;
            if (numerator < 0)
            {
                numerator = numerator * (-1);
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
            int t = sign * numerator * d.sign * d.denominator;
            int t2 = d.numerator * denominator;
            numerator = t;
            denominator = t2;
            if (numerator < 0)
            {
                numerator = numerator * (-1);
                sign = -1;
            }
            else
            {
                sign = 1;
            }
            Correct_fraction();
            Reduction();
        }
        //вычитание, умножение деление дописать

        public static Fraction operator +(Fraction b1, Fraction b2)
        {
            Fraction b = new Fraction();
            b1.Incorrect_fraction();
            b2.Incorrect_fraction();
            //integer = sign * integer - d.sign * d.integer;
            int k1 = (b1.sign * b1.numerator) * b2.denominator 
                + (b2.sign * (b2.numerator)) * b1.denominator;
            b.numerator = k1;
            b.denominator = b1.denominator * b2.denominator;
            if (b.numerator < 0)
            {
                b.numerator = b.numerator * (-1);
                b.sign = b.sign * (-1);
            }
            b.Correct_fraction();
            b.Reduction();
            return b;
        }
        public static Fraction operator -(Fraction b1, Fraction b2)
        {
            Fraction b = new Fraction();
            b1.Incorrect_fraction();
            b2.Incorrect_fraction();
            //integer = sign * integer - d.sign * d.integer;
            int k1 = (b1.sign * b1.numerator) * b2.denominator - (b2.sign * (b2.numerator)) * b1.denominator;
            b.numerator = k1;
            b.denominator = b1.denominator * b2.denominator;
            if (b.numerator < 0)
            {
                b.numerator = b.numerator * (-1);
                b.sign = b.sign * (-1);
            }
            b.Correct_fraction();
            b.Reduction();
            return b;
        }
        public static Fraction operator *(Fraction b1, Fraction b2)
        {
            Fraction b = new Fraction();
            b1.Incorrect_fraction();
            b2.Incorrect_fraction();
            int t = b1.sign * b1.numerator * b2.sign * b2.numerator;
            int t2 = b1.denominator * b2.denominator;
            b.numerator = t;
            b.denominator = t2;
            if (b.numerator < 0)
            {
                b.numerator = b.numerator * (-1);
                b.sign = -1;
            }
            else
            {
                b.sign = 1;
            }

            b.Correct_fraction();
            b.Reduction();
            return b;
        }
        public static Fraction operator /(Fraction b1, Fraction b2)
        {
            Fraction b = new Fraction();
            b1.Incorrect_fraction();
            b2.Incorrect_fraction();
            int t = b1.sign * b1.numerator * b2.sign * b2.denominator;
            int t2 = b2.numerator*b1.denominator;
            b.numerator = t;
            b.denominator = t2;
            if (b.numerator < 0)
            {
                b.numerator = b.numerator * (-1);
                b.sign = -1;
            }
            else
            {
                b.sign = 1;
            }

            b.Correct_fraction();
            b.Reduction();
            return b;
        }
        public static bool operator >= (Fraction b1, Fraction b2)
        {
            b1.Incorrect_fraction();
            b2.Incorrect_fraction();
            int k1 = b1.numerator * b1.sign * b2.denominator;
            int k2 = b2.numerator * b2.sign * b1.denominator;
            if (k1 >= k2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <=(Fraction b1, Fraction b2)
        {
            b1.Incorrect_fraction();
            b2.Incorrect_fraction();
            int k1 = b1.numerator * b1.sign * b2.denominator;
            int k2 = b2.numerator * b2.sign * b1.denominator;
            if (k1 <= k2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(Fraction b1, Fraction b2)
        {
            b1.Incorrect_fraction();
            b2.Incorrect_fraction();
            int k1 = b1.numerator * b1.sign * b2.denominator;
            int k2 = b2.numerator * b2.sign * b1.denominator;
            if (k1 < k2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >(Fraction b1, Fraction b2)
        {
            b1.Incorrect_fraction();
            b2.Incorrect_fraction();
            int k1 = b1.numerator * b1.sign * b2.denominator;
            int k2 = b2.numerator * b2.sign * b1.denominator;
            if (k1 > k2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator ==(Fraction b1, Fraction b2)
        {
            b1.Incorrect_fraction();
            b2.Incorrect_fraction();
            int k1 = b1.numerator * b1.sign * b2.denominator;
            int k2 = b2.numerator * b2.sign * b1.denominator;
            if (k1 == k2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator != (Fraction b1, Fraction b2)
        {
            b1.Incorrect_fraction();
            b2.Incorrect_fraction();
            int k1 = b1.numerator * b1.sign * b2.denominator;
            int k2 = b2.numerator * b2.sign * b1.denominator;
            if (k1 != k2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }



   

}



