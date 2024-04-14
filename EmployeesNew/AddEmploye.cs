using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesNew
{
    internal class AddEmploye
    {
        public void AddEmploeInFile(string employe)
        {
            ReadFile readFile = new ReadFile();
            string pathFile = readFile.pathFile;

            using (StreamWriter streamWriter = new StreamWriter(pathFile, true))
            {
                if (File.Exists(pathFile))
                {
                    streamWriter.WriteLine(employe);
                }
                else
                {
                    using (File.Create(pathFile))
                    {
                        streamWriter.WriteAsync(employe);
                    }
                }
            }
            Console.Clear();
        }
    }
}
