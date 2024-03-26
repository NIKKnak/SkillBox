namespace Cycles
{
    internal class Program
    {
        static void Main(string[] args)
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
