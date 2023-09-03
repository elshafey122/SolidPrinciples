using Single_Responsibility_Principle.After;

namespace Single_Responsibility_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestWithoutSRP();
            TestWithSRP();
        }

        private static void TestWithoutSRP()
        {
            var account =
                new Before.Account("Reem", "reem@example.com", 10000m);
            account.MakeTransaction(500);
            account.MakeTransaction(-11000);
        }

        private static void TestWithSRP()
        {
            var account =new After.Account("Reem", "reem@example.com", 10000m);
            TransictionServices trans = new TransictionServices();
            trans.Deposite(account, 1000);
            trans.Withdraw(account, 11500);
        }
    }
}