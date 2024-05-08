using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Class2
    {
        public int Method2(int value)
        {
            var thr2 = Thread.CurrentThread;

            thr2.Name = "Method2";

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Method2 = {value++}");
                Thread.Sleep(20);
            }
            Console.WriteLine($"Поток {thr2.Name}, id {thr2.GetHashCode()}");

            return value;

        }
    }
}
