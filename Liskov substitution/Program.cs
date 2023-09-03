using Liskov_substitution.After;

namespace Liskov_substitution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Account account = new Before.FixedDepositAccount("ali", 10000);
            //account.Deposite(1000);  
            //account.Withdraw(1000);  // exception error

            var account = new After.FixedDepositAccount("ali", 10000);
            account.Deposite(1000);
            account.Withdraw(1000);  // syntax  error
        }
    }
}