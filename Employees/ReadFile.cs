using System.Text;

namespace Employees
{
    internal class ReadFile
    {
        public readonly string pathFile = @"C:\Users\nik88\OneDrive\Desktop\SlillBox\TestFiles\1.txt";
        public void ReadTxtFile()
        {
            StringBuilder sb = new StringBuilder(500);

            using (StreamReader streamReader = new StreamReader(pathFile))
            {
                sb.Append(streamReader.ReadToEnd());

                string[] arrayValue = sb.ToString().Split('#');

                foreach (var item in arrayValue)
                {
                    Console.Write($"{item}\t");
                }

                Console.ReadKey();
                Console.Clear();
            }


            

        }


    }
}
