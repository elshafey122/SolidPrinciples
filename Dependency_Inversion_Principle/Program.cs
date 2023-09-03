using Dependency_Inversion_Principle.After;
//using Dependency_Inversion_Principle.Before;

namespace Dependency_Inversion_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //before
            //var customers = Repository.Customers;
            //foreach (var customer in customers)
            //{
            //NotificationService notific = new NotificationService(customer);
            //notific.send();
            //}

            var customers = Repository.Customers;
            foreach (var custom in customers)
            {
                var messages = new List<MessageServices>
                {
                    new EmailService
                    {
                        EmailAddress=custom.EmailAddress
                    },
                    new SMSService
                    {
                        MobileNo=custom.MobileNo
                    },
                    new TelegramService
                    {
                        TelegramAddress=custom.Address
                    }
                };

                //after constructor injection
                var sendmessages = new NotificationService(messages);
                sendmessages.Notify();


                //after properity injection
                //NotificationService1 not1 = new NotificationService1();
                //not1.SetServices(messages);
                //not1.Notify();


                //after method  injection
                //NotificationService2 not2 = new NotificationService2();
                //not2.Notify(messages);
            }
        }
    }
}