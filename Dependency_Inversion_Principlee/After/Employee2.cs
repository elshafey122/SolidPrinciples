using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
    public abstract class Employee2
    {
        public string EmployeeNo { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        protected abstract decimal CalculateNetSalary();
        public abstract string PrintSalarySlip();
    }
}
