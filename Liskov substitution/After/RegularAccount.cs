using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_substitution.After
{
    public abstract class RegularAccount : Account
    {
        public RegularAccount(string name, decimal balance) : base(name, balance)
        {
        }
        public abstract void Withdraw(decimal amount);
    }
}
