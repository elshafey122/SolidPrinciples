using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_substitution.Before
{
    public class CheckingAccount : Account
    {
        public CheckingAccount(string name, decimal balance) : base(name, balance)
        {

        }
        public override void Deposite(decimal amount)
        {
            Balance += amount;
        }
        public override void Withdraw(decimal amount)
        {
            if (amount > 1000)
            {
                Console.WriteLine("You cant withdram more than $1000");
            }
            Balance -= amount;
        }
    }
}
