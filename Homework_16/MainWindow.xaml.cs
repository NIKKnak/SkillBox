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

namespace Homework_16
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        

        public MainWindow()
        {
            InitializeComponent();

            /// <summary>
            /// строка подключение к локальной базе
            /// </summary>
            SqlConnectionStringBuilder strCon = new SqlConnectionStringBuilder()
            {
                DataSource = @"(LocalDB)\MSSQLLocalDB",
                InitialCatalog = "C:\\Users\\nik88\\OneDrive\\Документы\\MSSQLLocalDb.mdf",
                IntegratedSecurity = true,
                Pooling = true,

            };

            TextBlockDB1.Text = strCon.InitialCatalog;
            TextBlockDB2.Text = strCon.InitialCatalog;// подключить 2 базу
            ///
            using (SqlConnection connection = new SqlConnection(strCon.ConnectionString))
            {
                
                try
                {
                    connection.Open();
                    TextBlockDB1state.Text = connection.State.ToString();
                }
                catch (Exception)
                {

                    throw;
                }
            }



        }


    }
}