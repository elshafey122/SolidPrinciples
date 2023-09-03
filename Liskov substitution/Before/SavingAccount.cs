using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_substitution.Before
{
    public class SavingAccount:Account
    {
        public SavingAccount(string name, decimal balance) : base(name, balance)
        {

        }
        public override void Deposite(decimal amount)
        {
            Balance += amount;
        }
        public override void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
    }
}
