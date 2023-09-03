using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle.After
{
    public class TransictionServices
    {
        public void Withdraw(Account account ,decimal amount )
        {
            string TransactionMessage = "";
            if(amount>account.Balance)
            {
                TransactionMessage =
                    $"OVERDRAFT when trying to withdraw " +
                    $"{Math.Abs(amount).ToString("C2")}," +
                    $" current balance {account.Balance.ToString("C2")}";
            }
            else
            {
                account.Balance -= amount;
                TransactionMessage =
                       $"OK Withdraw {Math.Abs(amount).ToString("C2")}" +
                       $", current balance {account.Balance.ToString("C2")}";
            }
            EmailClient.Message(account,TransactionMessage, DateTime.Now);
        }

        public void Deposite(Account account, decimal amount)
        {
            string TransactionMessage = "";
            if (account.Balance>0)
            {
                account.Balance += amount;
                TransactionMessage =
                       $"OK Deposite {Math.Abs(amount).ToString("C2")}" +
                       $", current balance {account.Balance.ToString("C2")}";
            }
            EmailClient.Message(account, TransactionMessage, DateTime.Now);
        }
    }
}
