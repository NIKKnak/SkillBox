using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycles
{
    internal class TwentyOne
    {

        public void twentyOne()
        {
            Console.WriteLine("Укажите количество карт");
            int numbersMaps = Convert.ToInt32(Console.ReadLine());

            int result = 0;

            for (int i = 0; i < numbersMaps; i++)
            {
                Console.WriteLine($"Введите наминал {i + 1} карты :");

                string map = Console.ReadLine().ToUpper();


                switch (map)
                {
                    case "J":
                        result += 10;
                        break;
                    case "Q":
                        result += 10;
                        break;
                    case "K":
                        result += 10;
                        break;
                    case "T":
                        result += 10;
                        break;
                    default:
                        if (int.TryParse(map, out int value))
                        {
                            result += value;
                        }
                        else
                        {
                            Console.WriteLine("некорректный ввод");
                            i--;
                        }
                        break;
                }

            }

            if (result > 21)
            {
                Console.WriteLine($"Ваш результат {result} больше 21, ВЫ ПРОИГРАЛИ");

            }
            else
            {
                Console.WriteLine($"Ваш результат {result}");
            }


        }


    }
}
