using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.After
{
    public class TelegramService : MessageServices
    {
        public string TelegramAddress { set; get; }
        public override void Send()
        {
            Console.WriteLine($"telegram is sent to {TelegramAddress}");
        }
    }
}
