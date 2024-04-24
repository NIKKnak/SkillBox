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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListBox1.Items.Clear();

            string inputString = TextBox1.Text;
            
            string[] finish = inputString.Split(' ');

            foreach (var item in finish)
            {
                ListBox1.Items.Add(item);              
            }
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            string inputString = TextBox2.Text;

            string[] finish = inputString.Split(' ');

            Array.Reverse(finish);

            string reversedText = string.Join(" ",finish);

            Label2.Content = reversedText;

        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}