using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Manager : Client
    {
        public Manager(string lastName, string firstName, string patronymic, string phoneNumber, string passport)
            : base(lastName, firstName, patronymic, phoneNumber, passport)
        {

        }

        public new string PassportForConsultant
        {
            get { return base.GetPassport(); }
        }

        public void AddClientData(string lastName, string firstName, string patronymic, string phoneNumber, string passport)
        {
            base.SetClientData(lastName, firstName, patronymic, phoneNumber, passport);
        }
    }


}
