using System.Text;

namespace DataTipes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            Ф.И.О.
            Возраст
            Email
            Баллы по программированию
            Баллы по математике
            Баллы по физике
            */

            string fullName = "Ivanov Ivan Ivanovich";
            int age = 20;
            string email = "nik@mail.ru";
            double programmingPoints = 90.5d;
            double mathPoints = 80.7d;
            double physicsPoints = 70.3d;

            Console.WriteLine($"Ф.И.О. : {fullName}\nВозраст : {age}\nEmail : {email}\nБаллы по программированию : {programmingPoints}\nБаллы по математике : {mathPoints}\nБаллы по физике : {physicsPoints}\n");
            Console.WriteLine("---------------------------------------");

            double sumValue = programmingPoints + mathPoints + physicsPoints;
            double averageМalue = sumValue / 3;

            Console.ReadLine(); // просили вывод по нажитию

            Console.WriteLine($"Сумма баллов = {sumValue}");

            Console.ReadLine();// просили вывод по нажитию

            Console.WriteLine($"Средний балл = {averageМalue}");



            
        }
    }
}
