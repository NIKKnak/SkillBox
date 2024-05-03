using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class Account<T>
    {
        public T AccountNumber { get; }
        public decimal Balance { get; set; }

        public Account(T accountNumber, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }
        public void Transfer(Account<T> toAccount, decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Сумма должна быть больше нуля.");
            }

            if (Balance < amount)
            {
                throw new InvalidOperationException("Недостаточно средств.");
            }

            Balance -= amount;
            toAccount.Balance += amount;
        }

    }
}
