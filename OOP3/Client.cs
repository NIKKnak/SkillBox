using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class Client<T> : IClient
    {
        private int _id;
        private string _name;
        private List<Account<T>> _accounts;

        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public List<Account<T>> Accounts { get { return _accounts; }}
        public Client(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public void AddAccount(Account<T> account)
        {
            this._accounts.Add(account);
        }

        public void CloseAccount(Account<T> account)
        {
            this._accounts.Remove(account);
        }
    }
}
