namespace Employees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool runProgramm = true;
            while (runProgramm)
            {
                Console.WriteLine("Выберите действие:\nПрочитать файл: 1\nДобавить сотрудника: 2\nВыход: 3");
                int inputValue = Convert.ToInt32(Console.ReadLine());

                switch (inputValue)
                {
                    case 1:
                        ReadFile readFile = new ReadFile();
                        readFile.ReadTxtFile();
                        break;

                    case 2:
                        Console.Clear();
                        object[] newEmploye = new object[7];

                        Console.WriteLine("Введите ID пользователя:\n");
                        int id = Convert.ToInt32(Console.ReadLine());

                        DateTime dateTime = DateTime.Now;
                        string dateTimeConvert = Convert.ToString(dateTime);

                        Console.WriteLine("Введите ФИО пользователя:\n");
                        string fio = Console.ReadLine();

                        Console.WriteLine("Введите возраст сотрудника:\n");
                        int age = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Введите рост сотрудника:\n");
                        int height = Convert.ToInt32(Console.ReadLine());

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

                    case 3:
                        runProgramm = false;
                        break;
                }
            }
        }
    }
}
