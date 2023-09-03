using Open_Closed_Principle.after;

namespace Open_Closed_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quiz q1 = new Quiz(BankQuestions.Generate());
            q1.print();
        }
    }
}