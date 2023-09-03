using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.After
{
    internal class EmailService:MessageServices
    {
        public string EmailAddress { get; set; }


        public override void Send()
        {
            Console.WriteLine($"e-mail is sent to {EmailAddress}");
        }
    }
}
