using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_substitution.After
{
    public class FixedDepositAccount : Account
    {
        public FixedDepositAccount(string name,decimal balance):base(name,balance)
        {

        }
        public override void Deposite(decimal amount)
        {
            Balance += amount;
        }
    }
}
