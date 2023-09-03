using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_substitution.After
{
    public abstract class Account
    {
        public string Name { get; set; }
        public decimal Balance { get; set; }

        public Account(string name,decimal balance)
        {
            Name = name;
            Balance = balance;
        }
        public abstract void Deposite(decimal amount);
    }
}
