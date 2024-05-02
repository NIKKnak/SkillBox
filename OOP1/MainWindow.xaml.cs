using System;
using System.Reflection.Metadata;
using System.Windows;
using System.Windows.Controls;

namespace OOP1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Client> clients;
        public MainWindow()
        {

            InitializeComponent();

            clients = new List<Client>
            {
                new Consultant("Семенов", "Игорь", "Валерьевич", "+9055022365", "1111 111111"),
                new Consultant("Петров", "Иван", "Дмитриевич", "+9043656312", "2222 222222"),
                new Consultant("Сидоров", "Николай", "Константинович", "+9200254523", "3333 333333"),
                new Consultant("Консультант", "Петр", "Петрович", "+9047856512", "4444 444444"),
                new Manager("Менеджер", "Петр", "Петрович", "+9056548565", "5555 555555"),

            };

            foreach (Client client in clients)
            {
                comboBox1.Items.Add($"{client.LastName} {client.FirstName}");
            }

            foreach (Client client in clients)
            {
                comboBox2.Items.Add($"{client.LastName} {client.FirstName}");
            }


        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                string selectedClientName = comboBox1.SelectedItem.ToString();

                // Найдем клиента в списке по его имени
                Client selectedClient = clients.Find(client => $"{client.LastName} {client.FirstName}" == selectedClientName);

                // Проверим, является ли клиент консультантом
                if (selectedClient is Consultant)
                {
                    // Если клиент - консультант, то скроем паспорт и запретим редактирование ФИО
                    textBoxPassport.Text = "******************";
                    textBoxLastName.IsEnabled = false;
                    textBoxFirstName.IsEnabled = false;
                    textBoxPatronymic.IsEnabled = false;
                }
                else
                {
                    // Если клиент - не консультант, то отобразим паспорт и разрешим редактирование ФИО
                    //textBoxPassport.Text = selectedClient.GetPassport();
                    textBoxLastName.IsEnabled = true;
                    textBoxFirstName.IsEnabled = true;
                    textBoxPatronymic.IsEnabled = true;
                }
            }
        }


        private void comboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                string selectedClientName = comboBox2.SelectedItem.ToString();

                // Найдем клиента в списке по его имени
                Client selectedClient = clients.Find(client => $"{client.LastName} {client.FirstName}" == selectedClientName);

                // Отобразим данные клиента в текстовых полях интерфейса
                textBoxLastName.Text = selectedClient.LastName;
                textBoxFirstName.Text = selectedClient.FirstName;
                textBoxPatronymic.Text = selectedClient.Patronymic;
                textBoxPhoneNumber.Text = selectedClient.PhoneNumber; // Добавляем отображение номера телефона
                textBoxPassport.Text = selectedClient.GetPassport(); // Добавляем отображение номера телефона

                // Проверим, является ли клиент консультантом
                if (selectedClient is Consultant)
                {
                    // Если клиент - консультант, то скроем паспорт
                    textBoxPassport.Text = "******************";
                }
                else
                {
                    // Если клиент - не консультант, то отобразим паспорт
                    textBoxPassport.Text = selectedClient.GetPassport();
                }
            }
        }



        private void textBoxLastName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBoxFirstName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBoxPatronymic_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBoxPhoneNumber_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBoxPassport_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }


}
