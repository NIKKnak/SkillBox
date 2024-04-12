using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesNew
{
    internal class ReadFile
    {
        public readonly string pathFile = "Employe.txt";
        public void ReadTxtFile()
        {
            StringBuilder sb = new StringBuilder(500);

            if (File.Exists(pathFile))
            {
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
            else
            {
                using (File.Create(pathFile))
                {
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
}
