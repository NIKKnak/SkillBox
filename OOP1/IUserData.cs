using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    interface IUserData
    {
        string Name { get; set; }
        string Surname {  get; set; }
        string Patronymic { get; set; }
        decimal PhoneNumber { get; set; }
        int Series { get; set; }
        int PassportID { get; set; }

        void ViewingInformation() { }
    }
}

/*Фамилия
Имя
Отчество
Номер телефона
Серия, номер паспорта*/