using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Inversion_Principle.After
{
    public class NotificationService
    {
        private readonly List<MessageServices> _messageServices;

        // constructor injection
        public NotificationService( List<MessageServices> messageServices)
        {
            _messageServices = messageServices;
        }
        public void Notify()
        {
            foreach (var message in _messageServices)
            {
                message.Send();
            }
        }
    }

    public class NotificationService1
    {
        // properity injection
        public List<MessageServices> _messageServices { get; private set; }

        public void SetServices(List<MessageServices> messageServices)
        {
            _messageServices = messageServices;
        }
        public void Notify()
        {
            foreach (var message in _messageServices)
            {
                message.Send();
            }
        }
    }

    public class NotificationService2
    {
        // method injection
        public void Notify(List<MessageServices> messageServices)
        {
            foreach (var message in messageServices)
            {
                message.Send();
            }
        }
    }
}
