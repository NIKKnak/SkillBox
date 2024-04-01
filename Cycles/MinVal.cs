using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycles
{
    internal class MinVal
    {
        public void SearchMin()
        {
            Console.WriteLine("Введите длину последовательности");

            int enterSubsequence = Convert.ToInt32(Console.ReadLine());

            int searchValue = int.MaxValue;

            for (int i = 0; i < enterSubsequence; i++)
            {
                Console.WriteLine($"Введите {i+1} число из {enterSubsequence} :");
                int enterNumber = Convert.ToInt32(Console.ReadLine());
                if (enterNumber < searchValue)
                {
                    searchValue = enterNumber;
                }


            }

            Console.WriteLine($"Минимальное число в последовательности = {searchValue}");

        }




    }
}
