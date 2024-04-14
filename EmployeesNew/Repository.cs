using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesNew
{
    internal class Repository
    {
        public readonly string filePath = "Employe.txt";

        /// <summary>
        /// Вывести массив сотрудников
        /// </summary>
        /// <param name="workers"></param>
        public void PrintWorkers(Worker[] workers)
        {
            Console.WriteLine("Все сотрудники:");
            foreach (var worker in workers)
            {
                Console.WriteLine($"ID: {worker.Id}," +
                    $" Fio: {worker.Fio}," +
                    $" Age: {worker.Age}," +
                    $" Height: {worker.Height}," +
                    $" DateOfBirth: {worker.DateOfBirth}," +
                    $" PlaceOfBirth: {worker.PlaceOfBirth}");
            }
        }

        /// <summary>
        /// Вывести сотрудника
        /// </summary>
        /// <param name="worker"></param>
        public void PrintWorker(Worker worker)
        {
            Console.WriteLine($"ID: {worker.Id}," +
                    $" Fio: {worker.Fio}," +
                    $" Age: {worker.Age}," +
                    $" Height: {worker.Height}," +
                    $" DateOfBirth: {worker.DateOfBirth}," +
                    $" PlaceOfBirth: {worker.PlaceOfBirth}");
        }

        /// <summary>
        /// здесь происходит чтение из файла и возврат массива считанных экземпляров
        /// </summary>
        /// <returns></returns>
        public Worker[] GetAllWorkers()
        {
            if (!File.Exists(filePath))
            {
                using (File.Create(filePath)) { }
                return new Worker[0]; 
            }

            string[] lines = File.ReadAllLines(filePath);
            Worker[] workers = new Worker[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string[] data = lines[i].Split('#');
                workers[i] = new Worker
                {
                    Id = int.Parse(data[0]),
                    AddedDateTime = DateTime.ParseExact(data[1], "dd.MM.yyyy HH:mm", null),
                    Fio = data[2],
                    Age = int.Parse(data[3]),
                    Height = int.Parse(data[4]),
                    DateOfBirth = DateTime.ParseExact(data[5], "dd.MM.yyyy", null),
                    PlaceOfBirth = data[6]
                };
            }
            return workers;
        }

        /// <summary>
        /// происходит чтение из файла, возвращается Worker с запрашиваемым ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Worker GetWorkerById(int id, Worker[] workers)
        {
            foreach (var worker in workers)
            {
                if (worker.Id == id)
                    PrintWorker(worker);
            }
            return new Worker(); // Если не найден, возвращаем пустой объект Worker
        }

        /// <summary>
        /// считывается файл, находится нужный Worker происходит запись в файл всех Worker,кроме удаляемого
        /// </summary>
        /// <param name="id"></param>
        public void DeleteWorker(int id)
        {
            string[] lines = File.ReadAllLines(filePath);
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string line in lines)
                {
                    string[] data = line.Split('#');
                    if (int.Parse(data[0]) != id)
                        writer.WriteLine(line);
                }
            }
        }

        /// <summary>
        /// присваиваем worker уникальный ID, дописываем нового worker в файл
        /// </summary>
        /// <param name="worker"></param>
        public void AddWorker(Worker worker)
        {
            worker.Id = GenerateUniqueId();
            string newData = $"{worker.Id}#" +
                $"{worker.AddedDateTime.ToString("dd.MM.yyyy HH:mm")}#" +
                $"{worker.Fio}#" +
                $"{worker.Age}#" +
                $"{worker.Height}#" +
                $"{worker.DateOfBirth.ToString("dd.MM.yyyy")}#" +
                $"{worker.PlaceOfBirth}";

            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine(newData);
            }
        }

        /// <summary>
        /// Вывод работников по дате рождения
        /// </summary>
        /// <param name="dateFrom"></param>
        /// <param name="dateTo"></param>
        /// <returns></returns>
        public Worker[] GetWorkersBetweenTwoDates(DateTime dateFrom, DateTime dateTo)
        {
            Worker[] workers = GetAllWorkers();
            return workers.Where(worker => worker.DateOfBirth >= dateFrom && worker.DateOfBirth <= dateTo).ToArray();
        }

        private int GenerateUniqueId()
        {
            Worker[] workers = GetAllWorkers();
            return workers.Length == 0 ? 1 : workers.Max(worker => worker.Id) + 1;
        }
    }
}
