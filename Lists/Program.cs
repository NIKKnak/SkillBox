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

            Dictionary<int, string> myDictionary = new Dictionary<int, string>();
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


            }

            #endregion FoneBook

        }
    }
}
