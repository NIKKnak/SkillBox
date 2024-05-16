using Microsoft.Data.SqlClient;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace ADOnetDZ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string s = @"Data Source=(LocalDB)\MSSQLLocalDB;
            //AttachDbFilename=C:\Users\nik88\OneDrive\Документы\MSSQLLocalDb.mdf;
            //Integrated Security=True;
            //Connect Timeout=30;
            //Encrypt=True";

            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder()
            {
                DataSource = @"(LocalDB)\MSSQLLocalDB",
                InitialCatalog = "C:\\Users\\nik88\\OneDrive\\Документы\\MSSQLLocalDb.mdf",
                IntegratedSecurity = true,
                Pooling = true,

            };



            // чтение данных из базы
            try
            {
                using (SqlConnection c = new SqlConnection(strCon.ConnectionString))
                {
                    c.Open();
                    //Console.WriteLine(c.State);
                    var sql = @"select 
                                Id as 'id',
                                WorkerName as 'name',
                                departmantName as 'department'
                                from Bosses";

                    SqlCommand sqlCommand = new SqlCommand(sql, c);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    while (sqlDataReader.Read())
                    {
                        Console.WriteLine($"{sqlDataReader[0],4} | " +
                                          $"{sqlDataReader[1],4} | " +
                                          $"{sqlDataReader["department"],4} | ");

                    }


                }
            }
            catch (Exception)
            {

                throw;
            }





        }
    }
}
