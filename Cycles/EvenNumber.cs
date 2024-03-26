using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cycles
{
    internal class EvenNumber
    {
        public void EvenNum()
        {
            Console.WriteLine("Введите целочисленное число:");
            int enterNumber = int.Parse(Console.ReadLine());
            if (enterNumber % 2 == 0)
            {
                Console.WriteLine("число четное");
            }
            else
            {
                Console.WriteLine("число нечетноe");
            }
        }

    }
}
