namespace TaskAndThreads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task task1 = Task.Run(() => MyClass1("Сообщение 1", 2000));
            Task task2 = Task.Run(() => MyClass2("Сообщение 2", 3000));
            Task task3 = Task.Run(() => MyClass3("Сообщение 3", 1500));

            Task.WaitAll(task1, task2, task3);
        }

        static async Task MyClass1(string message, int delay)
        {
            Thread.CurrentThread.Name = "Поток 1";

            await Task.Delay(delay);

            Console.WriteLine($"{message} - Поток: {Thread.CurrentThread.Name}");
        }

        static async Task MyClass2(string message, int delay)
        {
            Thread.CurrentThread.Name = "Поток 2";

            await Task.Delay(delay);

            Console.WriteLine($"{message} - Поток: {Thread.CurrentThread.Name}");
        }
        static async Task MyClass3(string message, int delay)
        {
            Thread.CurrentThread.Name = "Поток 3";

            await Task.Delay(delay);

            Console.WriteLine($"{message} - Поток: {Thread.CurrentThread.Name}");
        }
    }
}
