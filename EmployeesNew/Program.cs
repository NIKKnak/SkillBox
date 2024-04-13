namespace EmployeesNew
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool runProgramm = true;
            while (runProgramm)
            {
                Console.WriteLine("Выберите действие:" +
                    "\nПрочитать файл: 1" +
                    "\nВыбрать сотрудника: 2" +
                    "\nДобавить сотрудника: 3" +
                    "\nУдалить сотрудника: 4" +
                    "\nВыход: 5");


                Repository repository = new Repository();
                Worker[] workers = repository.GetAllWorkers();

                int inputValue = Convert.ToInt32(Console.ReadLine());

                switch (inputValue)
                {
                    case 1:
                        repository.PrintWorkers(workers);
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 2:
                        Console.WriteLine($"Введите id сотрудника:");
                        int inputIdAdd = Convert.ToInt32(Console.ReadLine());



                        Worker selectedWorker = repository.GetWorkerById(inputIdAdd, workers);
                        if (selectedWorker.Id != 0)
                        {
                            Console.WriteLine("Выбранный сотрудник:");
                            repository.PrintWorker(selectedWorker);
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        Console.Clear();

                        Worker worker = new Worker();

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

                        worker = new Worker(id, dateTime, fio, age, height, dateOfBirth, placeOfBirth);
                        string newWorcer = worker.ToString();

                        AddEmploye employe = new AddEmploye();
                        employe.AddEmploeInFile(newWorcer);
                        break;

                    case 4:
                        Console.WriteLine($"Введите id сотрудника:");
                        int inputIdDel = Convert.ToInt32(Console.ReadLine());

                        repository.DeleteWorker(inputIdDel);
                        break;

                    case 5:

                        runProgramm = false;

                        break;

                }
            }
        }
    }
}
