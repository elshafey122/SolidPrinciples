using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.After
{
    internal class SMSService: MessageServices
    {
        public string MobileNo { get; set; }

        public override void Send()
        {
            Console.WriteLine($"SMS is sent to {MobileNo}");
        }
    }
}
