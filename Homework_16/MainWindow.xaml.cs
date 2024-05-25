using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Data.SqlClient;
using System.Data.OleDb;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Data;

namespace Homework_16
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataTable dt;
        DataRowView row;



        public MainWindow()
        {
            InitializeComponent();

            /// <summary>
            /// строка подключение к локальной базе 1
            /// </summary>
            SqlConnectionStringBuilder strCon1 = new SqlConnectionStringBuilder()
            {
                DataSource = @"(LocalDB)\MSSQLLocalDB",
                InitialCatalog = "C:\\Users\\nik88\\OneDrive\\Документы\\MSSQLLocalDb.mdf",
                IntegratedSecurity = true,
                Pooling = true,
            };
            /// <summary>
            /// строка подключение к локальной базе 2
            /// </summary>
            SqlConnectionStringBuilder strCon2 = new SqlConnectionStringBuilder()
            {
                DataSource = @"(LocalDB)\MSSQLLocalDB",
                InitialCatalog = "C:\\Users\\nik88\\OneDrive\\Документы\\MSSQLLocalDb2.mdf",
                IntegratedSecurity = true,
                Pooling = true,
            };

            TextBlockDB1.Text = strCon1.InitialCatalog;// подключить 1 базу
            TextBlockDB2.Text = strCon2.InitialCatalog;// подключить 2 базу

            using (SqlConnection connection1 = new SqlConnection(strCon1.ConnectionString))
            {
                try
                {
                    connection1.Open();

                    #region Меняем цвет текста
                    Color customColor = Color.FromRgb(0, 255, 0);
                    SolidColorBrush customBrush = new SolidColorBrush(customColor);
                    TextBlockDB1state.Foreground = customBrush;
                    #endregion

                    TextBlockDB1state.Text = connection1.State.ToString();

                }
                catch (Exception)
                {

                    throw;
                }
            }
            using (SqlConnection connection2 = new SqlConnection(strCon1.ConnectionString))
            {
                try
                {
                    connection2.Open();

                    #region Меняем цвет текста
                    Color customColor = Color.FromRgb(0, 255, 0);
                    SolidColorBrush customBrush = new SolidColorBrush(customColor);
                    TextBlockDB2state.Foreground = customBrush;
                    #endregion

                    TextBlockDB2state.Text = connection2.State.ToString();

                }
                catch (Exception)
                {

                    throw;
                }
            }


            //добовление записей в базу
            /*try
            {
                using (SqlConnection connection2 = new SqlConnection(strCon1.ConnectionString))
                {
                    connection2.Open();
                    string[] sqls =
                        {
                        "insert into workers(id,firstName,lastName) values (5,N'Начальние 4',N'отдел 4')"
                        };

                    SqlCommand command;
                    foreach (var sql in sqls)
                    {
                        command = new SqlCommand(sql, connection2);
                        command.ExecuteNonQuery();
                    }



                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Done");
            }*/






        }

        public void Preparing()
        {

            var connectionstringBilder = new SqlConnectionStringBuilder()
            {
                DataSource = @"(LocalDB)\MSSQLLocalDB",
                InitialCatalog = "C:\\Users\\nik88\\OneDrive\\Документы\\MSSQLLocalDb.mdf",
                IntegratedSecurity = true,
                Pooling = true,
            };

            con = new SqlConnection(connectionstringBilder.ConnectionString);
            dt = new DataTable();


            #region select
            da = new SqlDataAdapter();
            var sql = @"SELECT * FROM Workers";
            da.SelectCommand = new SqlCommand(sql, con);
            #endregion

            #region insert
            sql = @"INSERT INTO Workers (WorkerName,IdBoss,idDeskription)
                                VALUES (@WorkerName, @IdBoss, @idDeskription);
                           SET @id =    @@IDENTITY";

            da.InsertCommand = new SqlCommand(sql, con);

            da.InsertCommand.Parameters.Add("@id", SqlDbType.Int, 4, "id").Direction = ParameterDirection.Output;
            da.InsertCommand.Parameters.Add("@WorkerName", SqlDbType.NVarChar, 20, "WorkerName");
            da.InsertCommand.Parameters.Add("@IdBoss", SqlDbType.Int, 4, "IdBoss");
            da.InsertCommand.Parameters.Add("@idDeskription", SqlDbType.Int, 4, "idDeskription");

            #endregion

            #region update

            sql = @"IPDATE Workers Set
                    WorkerName = @WorkerName
                    IdBoss = @IdBoss
                    idDeskription = @idDeskription
                WHERE id = @id";

            da.UpdateCommand = new SqlCommand(sql, con);

            da.UpdateCommand.Parameters.Add("@id", SqlDbType.Int, 4, "id").Direction = ParameterDirection.Output;
            da.UpdateCommand.Parameters.Add("@WorkerName", SqlDbType.NVarChar, 20, "WorkerName");
            da.UpdateCommand.Parameters.Add("@IdBoss", SqlDbType.Int, 4, "IdBoss");
            da.UpdateCommand.Parameters.Add("@idDeskription", SqlDbType.Int, 4, "idDeskription");

            #endregion

            #region delete

            sql = "DELETE FROM Workers WHERE id = @id";

            da.DeleteCommand = new SqlCommand(sql, con);
            da.DeleteCommand.Parameters.Add("@id", SqlDbType.Int, 4, "id");


            #endregion

            da.Fill(dt);
            
            GridView gridView = new GridView();
            
        }

        private void AllViewShow(object sender, RoutedEventArgs e)
        {
            
        }

    }
}