using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OOP1.IUserData;

namespace OOP1
{
    class Consultant : UserBase
    {
        public Consultant(string name, string surname, string patronymic, decimal phoneNumber, int series, int passportId)
        : base(name, surname, patronymic, phoneNumber, series, passportId, role:Role.Consultant)
        {

        }


    }
}
