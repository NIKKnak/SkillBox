using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            }


            Console.WriteLine(sb);

        }


    }
}
