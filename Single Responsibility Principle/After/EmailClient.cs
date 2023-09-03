using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle.After
{
    public class EmailClient
    {
        public static void Message(Account account,string transmessage,DateTime date)
        {
            Console.WriteLine(
             $"\n\n\t\t To: {account.Email}" +
             $"\n\t\t Subject: Fake Bank Account Activity" +
             $"\n\n\t\t Dear {account.Name}," +
             $"\n\n\t\t\t A recent activity on your account occures at {date.ToString("yyyy-MM-dd hh:mm")}" +
             "\n\t\t\t\t ===> {0}" +
             $"\n\n\t\t Thank You,\n\t\t Fake Bank." +
             $"\n\n\t\t--------------------------- ", transmessage);
        }
    }
}
