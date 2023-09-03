using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle.Before
{
    public class Account
    {
        // need to be seperated in specific class
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Balance { get; set; }

        public Account(string name, string email, decimal balance)
        {
            this.Name = name;
            this.Email = email;
            this.Balance = balance;
        }
        public void MakeTransaction(decimal amount) // amount +/-
        {
            var transactionMessage = "";

            // handle withdraw need to be seperated in specific func
            if (amount < 0)
            {
                if (Balance < Math.Abs(amount))
                {
                    transactionMessage =
                    $"OVERDRAFT when trying to withdraw " +
                    $"{Math.Abs(amount).ToString("C2")}," +
                    $" current balance {Balance.ToString("C2")}";
                }
                else
                {
                    this.Balance -= amount;
                    transactionMessage =
                       $"OK Withdraw {Math.Abs(amount).ToString("C2")}" +
                       $", current balance {Balance.ToString("C2")}";
                }
            }
            else
            {
                // handle deposit need to be seperated in specific func
                if (amount > 0)
                {
                    this.Balance += amount;

                    transactionMessage =
                        $"OK Deposit {amount.ToString("C2")}" +
                        $", current balance {Balance.ToString("C2")}";
                }
            }

            // mock process for sending email need to be seperated in specific class
            Console.WriteLine(
             $"\n\n\t\t To: {Email}" +
             $"\n\t\t Subject: Fake Bank Account Activity" +
             $"\n\n\t\t Dear {Name}," +
             $"\n\n\t\t\t A recent activity on your account occures at {DateTime.Now.ToString("yyyy-MM-dd hh:mm")}" +
             "\n\t\t\t\t ===> {0}" +
             $"\n\n\t\t Thank You,\n\t\t Fake Bank." +
             $"\n\n\t\t--------------------------- ", transactionMessage);
        }
    }
}
