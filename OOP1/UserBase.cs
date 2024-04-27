using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using static OOP1.IUserData;

namespace OOP1
{
    public class UserBase : IUserData
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public decimal PhoneNumber { get; set; }
        public int Series { get; set; }
        public int PassportID { get; set; }
        public Role  role { get; set; }
        public override string ToString() => $"{Name}";
 

        public UserBase(string name, string surname, string patronymic, decimal phoneNumber, int series, int passportId, IUserData.Role role)
        {
            this.Name = name;
            this.Surname = surname;
            this.Patronymic = patronymic;
            this.PhoneNumber = phoneNumber;
            this.Series = series;
            this.PassportID = passportId;
            this.role = role;
        }

        void ViewingInformation(UserBase user, UserBase userInList)
        {

            if (user.role == IUserData.Role.Consultant)
            {
                string seriesNumbera = HideSensitiveData(Convert.ToString(userInList.Series));
                string passportIdNumber = HideSensitiveData(Convert.ToString(userInList.PassportID));
            }
            else
            {

            }
        }

        static string HideSensitiveData(string data)
        {

            return new string('*', data.Length);
        }

    }
}
