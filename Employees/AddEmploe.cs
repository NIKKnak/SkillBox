using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    internal class AddEmploe
    {
        public void AddEmploeInFile(string[] array)
        {
            ReadFile readFile = new ReadFile();
            string pathFile = readFile.pathFile;

            using (StreamWriter streamWriter = new StreamWriter(pathFile,true))
            {
                if (File.Exists(pathFile))
                {
                    streamWriter.WriteLine("\n"); // <---добавил переход, не получилось с переходом н новую строку
                    foreach (var item in array)
                    {
                        streamWriter.WriteAsync(item+'#'); // <--- не получилось убрать знак # в конце
                    }                 
                }
                else
                {
                    using (File.Create(pathFile))
                    {
                        streamWriter.WriteLine("\n"); 
                        foreach (var item in array)
                        {
                            streamWriter.WriteAsync(item + '#');
                        }
                    }
                }
            }
        }
    }
}
