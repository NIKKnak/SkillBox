using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OOP1.IUserData;
namespace OOP1
{
    public class Manager : UserBase
    {
        public Manager(string name, string surname, string patronymic, decimal phoneNumber, int series, int passportId, IUserData.Role role= Role.Manager)
        : base(name, surname, patronymic, phoneNumber, series, passportId, role:Role.Manager)
        {


        }
        public new Role role { get; set; } = Role.Manager;
        public override string ToString()
        {
            return $"{Surname} {Name} {Patronymic} ";
        }


    }
}
