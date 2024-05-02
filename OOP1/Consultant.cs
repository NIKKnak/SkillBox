using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Consultant : Client
    {
        public Consultant(string lastName, string firstName, string patronymic, string phoneNumber, string passport)
            : base(lastName, firstName, patronymic, phoneNumber, passport)
        {
        }

        // Переопределение метода для скрытия паспорта консультанта
        public override string PassportForConsultant
        {
            get { return "******************"; }
        }
    }

}
