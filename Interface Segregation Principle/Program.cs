using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Interface_Segregation_Principle
{
    public class Program
    {
        static void Main(string[] args)
        {
            var employees = Repository.LoadEmployees();
            foreach (var Emp in employees)
            {
                Emp.PrintSalarySlip();
                Console.WriteLine();
            }
        }
    }
}
