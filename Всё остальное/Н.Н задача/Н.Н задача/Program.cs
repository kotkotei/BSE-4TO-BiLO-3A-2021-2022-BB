using System;

namespace Н.Н_задача
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите Пожалуйста свои данные!");   
            
            Console.Write("ФИО ");
            string fio = Convert.ToString(Console.ReadLine());

            Console.Write("Возраст ");
            int Vozrast = Convert.ToInt32(Console.ReadLine());

            Console.Write("Email ");
            string Email = Convert.ToString(Console.ReadLine());
           

            Console.Write("Баллы по програмированию ");
            double BallPopr = Convert.ToInt32(Console.ReadLine());

            Console.Write("Баллы по матиматике ");
            double BallMat = Convert.ToInt32(Console.ReadLine());

            Console.Write("Баллы по физике");
           double BallFiz = Convert.ToInt32(Console.ReadLine());
            
            double t = BallPopr + BallMat + BallFiz;
            double v = t / 2;
            double z = t / 3;
           

            Console.WriteLine(" Фио ,"  +  fio   +   " Возраст "    +    Vozrast    +    " Email "   +   Email   +      " Балл по рограмированию "  +   BallPopr   + " Балл по Матиматике " +   BallMat  +   " Балл по Физике "  + BallFiz);
            Console.WriteLine("Сумма баллов по всем предметам " +  t);
            Console.WriteLine("Средний балл по предметам " + v);
            Console.WriteLine("Средний Арефметическое " + v);
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Console.ReadKey();

        }
    }
}
