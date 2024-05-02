using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;


namespace OOP1
{
    public class Client
    {
        private string _lastName;
        private string _firstName;
        private string _patronymic;
        private string _phoneNumber;
        private string _passport;
        private DateTime _lastModificationDate;
        private string _modificationType;
        private string _modifierType;

        public Client(string lastName, string firstName, string patronymic, string phoneNumber, string passport)
        {
            _lastName = lastName;
            _firstName = firstName;
            _patronymic = patronymic;
            _phoneNumber = phoneNumber;
            _passport = passport;
            _lastModificationDate = DateTime.MinValue;
            _modificationType = "";
            _modifierType = "";
        }

        public string GetPassport()
        {
            return _passport;
        }

        public void SetClientData(string lastName, string firstName, string patronymic, string phoneNumber, string passport)
        {
            _lastName = lastName;
            _firstName = firstName;
            _patronymic = patronymic;
            _phoneNumber = phoneNumber;
            _passport = passport;
        }

        public string LastName
        {
            get { return _lastName; }
        }

        public string FirstName
        {
            get { return _firstName; }
        }

        public string Patronymic
        {
            get { return _patronymic; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                _phoneNumber = value;
                _lastModificationDate = DateTime.Now;
                _modificationType = "Изменение номера телефона";
                _modifierType = "Консультант";
            }
        }

        public virtual string PassportForConsultant
        {
            get { return "******************"; }
        }

        public DateTime LastModificationDate
        {
            get { return _lastModificationDate; }
        }

        public string ModificationType
        {
            get { return _modificationType; }
        }

        public string ModifierType
        {
            get { return _modifierType; }
        }

        public override string ToString()
        {
            return $"Фамилия: {_lastName}" +
                $"\nИмя: {_firstName}" +
                $"\nОтчество: {_patronymic}" +
                $"\nНомер телефона: {_phoneNumber}" +
                $"\nСерия, номер паспорта: {PassportForConsultant}" +
                $"\nДата и время последнего изменения: {_lastModificationDate}" +
                $"\nТип изменений: {_modificationType}" +
                $"\nКто изменил данные: {_modifierType}";
        }
    }

}
