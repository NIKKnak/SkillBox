using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Employees
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Выберите действие:\nПрочитать файл: 1\nДобавить сотрудника: 2");
                int inputValue = Convert.ToInt32(Console.ReadLine());

                switch (inputValue)
                {
                    case 1:
                        ReadFile readFile = new ReadFile();
                        readFile.ReadTxtFile();
                        break;

                    case 2:
                        Console.Clear();
                        string[] newEmploye = new string[7];

                        Console.WriteLine("Введите ID пользователя:\n");
                        string id = Console.ReadLine();

                        DateTime dateTime = DateTime.Now;
                        string dateTimeConvert = Convert.ToString(dateTime);

                        Console.WriteLine("Введите ФИО пользователя:\n");
                        string fio = Console.ReadLine();

                        Console.WriteLine("Введите возраст сотрудника:\n");
                        string age = Console.ReadLine();

                        Console.WriteLine("Введите рост сотрудника:\n");
                        string height = Console.ReadLine();

                        Console.WriteLine("Введите дату рождения сотрудника:\n");
                        DateTime dateOfBirth = Convert.ToDateTime(Console.ReadLine());
                        string dateOfBirthConvert = Convert.ToString(dateOfBirth);

                        Console.WriteLine("Введите место рождения сотрудника:\n");
                        string placeOfBirth = Console.ReadLine();

                        newEmploye[0] = id;
                        newEmploye[1] = dateTimeConvert;
                        newEmploye[2] = fio;
                        newEmploye[3] = age;
                        newEmploye[4] = height;
                        newEmploye[5] = dateOfBirthConvert;
                        newEmploye[6] = placeOfBirth;

                        AddEmploe addEmploe = new AddEmploe();
                        addEmploe.AddEmploeInFile(newEmploye);

                        break;
                }
            }
        }
    }
}
