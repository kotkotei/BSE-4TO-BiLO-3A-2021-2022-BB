using System;

namespace Н.Н_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" \"Blackjack\"");
            int sum = 0;
            Console.WriteLine("Введи количество карточек: ");
            int countCard = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= countCard; i++)
            {
                Console.WriteLine("Enter получи карту: ");
                string numberCard = Console.ReadLine();
                switch (numberCard)
                {
                    case "J":
                        sum += 10;
                        break;
                    case "Q":
                        sum += 10;
                        break;
                    case "K":
                        sum += 10;
                        break;
                    case "T":
                        sum += 11;
                        break;
                    default:
                        var count = Convert.ToInt32(numberCard);
                        sum += count;
                        break;
                }
            }
            Console.WriteLine($"Сумма карт = { sum }");
            Console.ReadKey();
        }
    }
}