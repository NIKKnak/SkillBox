using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Class1
    {

        public int Method1(int value)
        {
            
            var thr1 = Thread.CurrentThread;

            thr1.Name = "Method1";

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Method1 = {value++}");
                Thread.Sleep(20);
            }

            Console.WriteLine($"Поток {thr1.Name}, id {thr1.GetHashCode()}");

            return value;
        }




    }
}
