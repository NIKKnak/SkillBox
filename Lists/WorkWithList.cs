using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class WorkWithList
    {

        public List<int> FillList(List<int> myList)
        {

            Random random = new Random();

            Console.WriteLine("Заполненный лист");
            for (int i = 0; i <= 100; i++)
            {
                myList.Add(random.Next(0, 100));
            }

            return myList;
        }

        public void PrintList(List<int> myList)
        {
            myList.Sort();

            foreach (var item in myList)
            {
                Console.Write(item + " ");
            }

        }

        public List<int> DelValue(List<int> myList)
        {
            myList.RemoveAll(x => x > 25 && x < 50); // не работает без sort           
            return myList;
        }

    }
}
