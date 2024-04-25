using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class UserBase : IUserData
    {
        public string Name { get ; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public decimal PhoneNumber { get ; set; }
        public int Series { get; set; }
        public int PassportID { get ; set; }

        public UserBase(string name, string surname, string patronymic, decimal phoneNumber, int series, int passportId)
        { 
            this.Name = name;
            this.Surname = surname;
            this.Patronymic = patronymic;
            this.PhoneNumber = phoneNumber;
            this.Series = series;
            this.PassportID = passportId;    
        }
    }
}
