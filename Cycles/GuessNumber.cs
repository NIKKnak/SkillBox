using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycles
{
    internal class GuessNumber
    {
        public void GameGuessNumber()
        {
            Console.WriteLine("Введите максимальное число");
            int enterMaxNumber = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            int rnd = random.Next(0,enterMaxNumber);

            bool examination = true;



            //Console.ReadKey(true).Key == ConsoleKey.Enter


            Console.Clear();

            while (examination)
            {
                Console.WriteLine("Угадайте число");
                int enterValue = Convert.ToInt32(Console.ReadLine());

                if (rnd == enterValue)
                {
                    Console.Clear();
                    Console.WriteLine($"Ты угадал!!! Это число {rnd}");
                    break;
                }
                if (!examination)
                {
                    Console.WriteLine($"Игра закончена. Было загадано число: {rnd}");
                    examination = false;

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Неверно");
                }






            }




        }
    }
}
