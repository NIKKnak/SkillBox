using System;
using System.Windows;
using System.Windows.Controls;

namespace OOP1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            List<UserBase> users = new List<UserBase>();
            comboBox1.ItemsSource = UsersList(users);
            comboBox2.ItemsSource = users;
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }




        public List<UserBase> UsersList(List<UserBase> users)
        {
            users.Add(new Manager("aaa", "sss", "ddd", 11111, 1234, 11111111));
            users.Add(new Consultant("aaa", "sss", "ddd", 11111, 1234, 11111111));
            users.Add(new Consultant("aaa", "sss", "ddd", 11111, 1234, 11111111));

            return users;
        }









    }


}
