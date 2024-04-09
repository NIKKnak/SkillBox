using System.ComponentModel.DataAnnotations;

namespace Employees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            a();
            

            


        }

        public static void a()
        {
            var data = DateTime.Now;

            int sum = 0;

            for (int i = 0; i < 1000000000; i++)
            {
                sum += i;

            }
            Console.WriteLine(sum);
            TimeSpan timeSpan = DateTime.Now - data;
            Console.WriteLine(timeSpan.Milliseconds);
        }


    }
}
