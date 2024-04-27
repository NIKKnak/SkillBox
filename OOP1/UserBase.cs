using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class UserBase : IUserData
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public decimal PhoneNumber { get; set; }
        public int Series { get; set; }
        public int PassportID { get; set; }
        public IUserData.Role role { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


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

        public List<UserBase> users = new List<UserBase>();

        public List<UserBase> Users(UserBase user)
        {
            users.Add(user);

            return users;
        }



        void ViewingInformation(UserBase user, UserBase userInList)
        {
           
            if (user.role == IUserData.Role.Consultant)
            {
                string seriesNumbera  = HideSensitiveData(Convert.ToString(userInList.Series));
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
