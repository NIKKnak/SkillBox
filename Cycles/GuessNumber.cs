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

            Console.Clear();

            while (true)
            {
                Console.WriteLine("Угадайте число");
                string input = Console.ReadLine();

                if (input == "")
                {
                    Console.WriteLine($"Игра закончена. Было загадано число: {rnd}");
                    break;

                }

                int enterValue;
                if (!int.TryParse(input,out enterValue))
                {
                    Console.WriteLine("Ошибка ввода. Dвведите целое число или нажмите Enter для выхода.");
                    continue;
                }

                if (rnd == enterValue)
                {
                    Console.Clear();
                    Console.WriteLine($"Ты угадал!!! Это число {rnd}");
                    break;
                }
                
                if (rnd > enterValue)
                {
                    Console.Clear() ;
                    Console.WriteLine($"Неверно, загаданное число больше");
                }

                if (rnd < enterValue)
                {
                    Console.Clear();
                    Console.WriteLine($"Неверно, загаданное число меньше");
                }
            }
        }
    }
}
