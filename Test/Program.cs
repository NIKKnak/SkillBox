using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

     




        }







        static void PerformComputation(int taskNum)
        {
            Console.WriteLine($"Task {taskNum} starting computation...");
            // Имитация вычислительно интенсивной задачи
            for (int i = 0; i < 1000000000; i++) ;
            Console.WriteLine($"Task {taskNum} completed computation.");

        }
        static async Task<string> FetchDataAsync()
        {
            await Task.Delay(2000); // имитируем задержку в 2 секунды
            return "11111";
        }

        static async Task<string> ProcessDataAsync()
        {
            string data = await FetchDataAsync();
            return $"22222: {data}";
        }


    }
}
