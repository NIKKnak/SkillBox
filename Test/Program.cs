using System.Security.Cryptography.X509Certificates;

namespace Test
{
    internal class Program
    {
        public static int o = 0;
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Class2 class2 = new Class2();

            

            Thread thread1 = new Thread(class1.Method1);

            Thread thread2 = new Thread(class2.Method2);

            thread1.Start();
            thread2.Start();

        }


    }
}
