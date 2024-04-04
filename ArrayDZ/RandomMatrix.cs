using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDZ
{
    internal class RandomMatrix
    {
        public void Matrix()
        {
            Console.WriteLine($"Введите количество строк");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Введите количество столбцов");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] MyArray = new int[rows, cols];

            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    MyArray[i, j] = random.Next(0, 100);
                }
            }

            Console.Clear();

            for (int i = 0; i < MyArray.GetLength(0); i++)
            {
                for (int j = 0; j < MyArray.GetLength(1); j++)
                {
                    Console.Write(MyArray[i, j] + " ");
                }
                Console.WriteLine();
            }

            int sumMatrixNumber = 0;

            foreach (var item in MyArray)
            {
                sumMatrixNumber += item;
            }

            Console.WriteLine($"Сумма всех чисел = {sumMatrixNumber}");


        }
    }
}
