using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.Before
{
    internal class NotificationService
    {
        private readonly Customer _customer;
        private readonly EmailService _emailService;
        private readonly SMSService _smsService;
        public NotificationService(Customer _customer)
        {
            _emailService = new EmailService
            {
                EmailAddress = _customer.EmailAddress
            };
            _smsService = new SMSService
            {
                MobileNo = _customer.MobileNo
            };
        }
        public void send()
        {
            _emailService.Send();
            _smsService.Send();
        }
    }
}
