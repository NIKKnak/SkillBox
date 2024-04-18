using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lists
{
    internal class FoneBook
    {

        public Dictionary<int, string> addContakt(int number, string fio, Dictionary<int, string> myDictionary)
        {
            if (number == null || fio == null)
            {
                return myDictionary;
            }
            else
            {
                myDictionary.Add(number, fio);
                return myDictionary;
            }
        }

        public void PrintValue(Dictionary<int, string> myDictionary)
        {
            Console.WriteLine("Введите номер контакта");
            int number = Convert.ToInt32(Console.ReadLine());

            if (myDictionary.ContainsKey(number))
            {
                string value = myDictionary[number];

                Console.WriteLine();
                Console.WriteLine($"Телефон: {number} Пользователь: {value}");
            }
            else
            {
                Console.WriteLine("Нет данного пользователя");
            }

        }

        public void PrintDictionary(Dictionary<int, string> myDictionary)
        {
            foreach (KeyValuePair<int, string> item in myDictionary)
            {
                Console.WriteLine($"Телефон: {item.Key} Пользователь: {item.Value}");
            }
        }
    }
}
