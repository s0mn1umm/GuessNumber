using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 101);
            Console.WriteLine("Я загадал число от 1 до 100. Попробуй угадать!");

            while (true)
            {
                Console.Write("Твой вариант: ");
                int guess = int.Parse(Console.ReadLine());

                if (guess < number)
                {
                    Console.WriteLine("Моё число больше.");
                }
            }
        }
    }
}
