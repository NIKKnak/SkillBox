using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Cycles
{
    internal class CheckingNumber
    {
        public void Check()
        {

            Console.WriteLine("Введите число");
            int enterNumber = int.Parse(Console.ReadLine());

            bool checking = true;
            int i = 2;

            while (i < enterNumber)
            {
                if (enterNumber % i == 0)
                {
                    checking = false;
                    break;
                }
                i++;
            }

            if (checking)
                Console.WriteLine($"{enterNumber} простое число.");
            else
                Console.WriteLine($"{enterNumber} не является простым числом.");

        }


    }
}
