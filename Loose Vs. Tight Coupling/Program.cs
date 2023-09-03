namespace Loose_Vs._Tight_Coupling
{

    // way of tight coupling:

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        NotificationService serv = new NotificationService(new EmailService(), new SmsService());
    //        serv.notify();
    //    }

    //    public class NotificationService
    //    {
    //        private EmailService _emailservice;
    //        private SmsService _smsservice;
    //        public NotificationService(EmailService emailservice,SmsService smsservice)
    //        {
    //            _emailservice = emailservice;
    //            _smsservice = smsservice;
    //        }
    //        public void notify()
    //        {
    //            _emailservice.Send();
    //            _smsservice.Send();
    //        }
    //    }
    //    public class EmailService
    //    {
    //        public void Send()
    //        {
    //            Console.WriteLine("email sent");
    //        }
    //    }
    //    public class SmsService
    //    {
    //        public void Send()
    //        {
    //            Console.WriteLine("sms sent");
    //        }
    //    }
    //}

    internal class Program
    {
        static void Main(string[] args)
        {
            var service = ProviderFactory.CreateService(new List<Provider> {Provider.Sms,Provider.Telegram,Provider.Email,Provider.whats});
            NotificationService serv = new NotificationService(service);
            serv.notify();
        }
        public class ProviderFactory
        {
            public static List<InotificationMode> CreateService(List<Provider> type)
            {
                List<InotificationMode> _CreateServices = new List<InotificationMode>();
                foreach (Provider typeItem in type)
                {
                    switch (typeItem)
                    {
                        case Provider.Sms:
                            _CreateServices.Add(new SmsService());
                            break;
                        case Provider.whats:
                            _CreateServices.Add(new WhatsService());
                            break;
                        case Provider.Email:
                            _CreateServices.Add(new EmailService());
                            break;
                        case Provider.Telegram:
                            _CreateServices.Add(new telegramService());
                            break;
                        default:
                            _CreateServices.Add(new EmailService());
                            break;
                    }
                }
                return _CreateServices;
            }
        }
        public enum Provider
        {
            Email,
            Sms,
            whats,
            Telegram,
        }
        public class NotificationService
        {
            private List<InotificationMode> _inotificationmodes;
            public NotificationService(List<InotificationMode> inotificationmodes)
            {
                _inotificationmodes = inotificationmodes;
            }
            public void notify()
            {
                foreach (var notific in _inotificationmodes)
                {
                    notific.Send();
                }
            }
        }
        public interface InotificationMode
        {
            public void Send();

        }
        public class SmsService:InotificationMode
        {
            public void Send()
            {
                Console.WriteLine("sms sent");
            }
        }
        public class EmailService: InotificationMode
        {
            public void Send()
            {
                Console.WriteLine("email sent");
            }
        }
        public class WhatsService : InotificationMode
        {
            public void Send()
            {
                Console.WriteLine("whats sent");
            }
        }
        public class telegramService : InotificationMode
        {
            public void Send()
            {
                Console.WriteLine("telegram sent");
            }
        }
    }
}