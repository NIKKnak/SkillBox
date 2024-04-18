using System.Collections.Generic;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DZ1
            /*WorkWithList workWithList = new WorkWithList();

            List<int> myList = new List<int>();

            workWithList.FillList(myList);
            workWithList.PrintList(myList);
            workWithList.DelValue(myList);
            Console.WriteLine();
            Console.WriteLine();
            workWithList.PrintList(myList);*/
            #endregion DZ1

            #region FoneBook

            /*Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            FoneBook foneBook = new FoneBook();

            while (true)
            {
                Console.WriteLine($"Добавить контакт: 1\nНайти контакт: 2\nПоказать все контакты: 3\n");
                int inputValue = Convert.ToInt32(Console.ReadLine());
                switch (inputValue)
                {
                    case 1:
                        Console.WriteLine($"Введите номер телефона пользователя");
                        int foneNumber = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"Введите ФИО пользователя");
                        string fio = Console.ReadLine();

                        foneBook.addContakt(foneNumber, fio, myDictionary);
                        Console.Clear();
                        break;

                    case 2:
                        foneBook.PrintValue(myDictionary);
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        foneBook.PrintDictionary(myDictionary);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }*/

            #endregion FoneBook

            #region Checking repetitions


            CheckingRepetitions checkingRepetitions = new CheckingRepetitions();

            HashSet<int> myHashSet = new HashSet<int>();
            bool start = true;

            while (start)
            {
                Console.WriteLine($"Добавить значение: 1\nПоказать все значения: 2\nВыход: 3");
                int inputValue = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (inputValue)
                {
                    case 1:
                        Console.WriteLine("Введите значение\n");
                        int value = Convert.ToInt32(Console.ReadLine());
                        checkingRepetitions.AddInHash(myHashSet, value);

                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        checkingRepetitions.PrintHashSet(myHashSet);

                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        start = false;
                        break;
                }
            }

            #endregion Checking repetitions
        }
    }
}
