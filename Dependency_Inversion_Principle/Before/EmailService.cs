using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.Before
{
    internal class EmailService
    {
        public string EmailAddress { get; set; }


        public void Send()
        {
            Console.WriteLine($"e-mail is sent to {EmailAddress}");
        }
    }
}
