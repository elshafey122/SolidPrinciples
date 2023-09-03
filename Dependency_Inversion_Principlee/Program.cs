using Interface_Segregation_Principle;

namespace Dependency_Inversion_Principlee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = Repository.LoadEmployees();
            var employees2 = Repository2.LoadEmployees();

            //before
            foreach (var Emp in employees)
            {
                Console.WriteLine(Emp.PrintSalarySlip());
                Console.WriteLine();
            }

            //after
            foreach (var Emp in employees2)
            {
                Console.WriteLine(Emp.PrintSalarySlip());
                Console.WriteLine();
            }
        }
    }
}