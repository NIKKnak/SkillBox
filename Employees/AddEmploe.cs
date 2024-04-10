namespace Employees
{
    internal class AddEmploe
    {
        public void AddEmploeInFile(object[] array)
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
                        streamWriter.WriteAsync(Convert.ToString(item)+'#'); // <--- не получилось убрать знак # в конце
                    }                 
                }
                //повторение кода(нехорошо)
                else
                {
                    using (File.Create(pathFile))
                    {
                        streamWriter.WriteLine("\n"); // <---добавил переход, не получилось с переходом н новую строку
                        foreach (var item in array)
                        {
                            streamWriter.WriteAsync(Convert.ToString(item) + '#'); // <--- не получилось убрать знак # в конце
                        }
                    }
                }
            }
            Console.Clear();
        }
    }
}
