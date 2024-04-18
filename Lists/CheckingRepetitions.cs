using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    internal class CheckingRepetitions
    {
        public HashSet<int> AddInHash(HashSet<int> hashSet, int value)
        {
            if (hashSet.Contains(value))
            {
                Console.WriteLine("Знычение уже содержится в базе");
            }
            else
            {
                hashSet.Add(value);
            }
            return hashSet;
        }

        public void PrintHashSet(HashSet<int> hashSet)
        {

            foreach (var item in hashSet)
            {
                Console.Write(item + " ");
            }


        }


    }
}
