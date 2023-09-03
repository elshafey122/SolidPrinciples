using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
    class Daylabourer2 : Employee2, ICalculateHealthInsurance2 , ICalculateTransportationReimbursement2
    {
        public decimal CalculateHealthInsurance() => 300m;        

        public decimal CalculateTransportationReimbursement() => 150;

        protected override decimal CalculateNetSalary()
        {
            return Salary
                + CalculateHealthInsurance()
                + CalculateTransportationReimbursement();
        }

        public override string PrintSalarySlip()
        {
            return $"\n --- {nameof(Daylabourer2)} ---" +
                  $"\n  No.: {EmployeeNo}" +
                  $"\n  Name: {Name}" +
                  $"\n  Basic Salary: {Salary.ToString("C2")}" +
                  $"\n  Health Insurance: {CalculateHealthInsurance().ToString("C2")}" +
                  $"\n  Transportation Reimbursement: {CalculateTransportationReimbursement().ToString("C2")}" +
                  $"\n  ----------------------------------------------" +
                  $"\n  NetSalary: {CalculateNetSalary().ToString("C2")}";
        }
    }
}
