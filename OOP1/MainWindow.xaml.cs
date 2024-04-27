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

            comboBox1.Items.Add("sad");
                
          
            /*comboBox1.ItemsSource = userBase;
            comboBox1.DisplayMemberPath = "Name"*/;
            

        }



        /*public List<UserBase> users()
        {
            List<UserBase> users = new List<UserBase>()
            {
                new Manager("aaa", "sss", "ddd", 1234, 1111, 111),
                new Manager("qqq", "www", "eee", 3214, 2222, 222),
                new Consultant("zzz", "xxx", "ccc", 5325, 3333, 333)
            };

            return users;
        }*/

    }


}
