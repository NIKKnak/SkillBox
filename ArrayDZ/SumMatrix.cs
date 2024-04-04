namespace ArrayDZ
{
    internal class SumMatrix
    {
        public void SumOfTwoMatrix()
        {
            Console.WriteLine($"Введите количество строк");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Введите количество столбцов");
            int cols = Convert.ToInt32(Console.ReadLine());

            int[,] FirstArray = new int[rows, cols];
            int[,] SecondArray = new int[rows, cols];

            FillingMatrix(FirstArray, rows, cols);
            FillingMatrix(SecondArray, rows, cols);

            Console.Clear();

            PrintMatrix(FirstArray);
            PrintMatrix(SecondArray);

            Console.WriteLine();


            Console.WriteLine($"Сложение массивов");

            PrintMatrix(SumTwoMatrix(FirstArray, SecondArray));

        }

        public int[,] FillingMatrix(int[,] array, int rows, int cols)
        {
            Random random = new Random();


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = random.Next(0, 100);
                }
            }



            return array;
        }

        public void PrintMatrix(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public int[,] SumTwoMatrix(int[,] firstArray, int[,] secondArray)
        {

            int rows = firstArray.GetLength(0);
            int cols = firstArray.GetLength(1);

            int[,] resultArray = new int[rows, cols];

            for (int i = 0; i < firstArray.GetLength(0); i++)
            {
                for (int j = 0; j < secondArray.GetLength(1); j++)
                {
                    resultArray[i, j] = firstArray[i, j] + secondArray[i, j];
                }
            }
            return resultArray;
        }
    }
}
