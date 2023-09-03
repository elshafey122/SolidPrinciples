using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
    static class Repository
    {
        public static IEnumerable<Employee> LoadEmployees()
        {
            return new List<Employee>
            {
                new Staff
                {
                    EmployeeNo="2017-FI-1343",
                    Name="Ali",
                    Salary=13445,
                },
                new Consultant
                {
                    EmployeeNo="2018-FI-1343",
                    Name="Salah",
                    Salary=9474,
                },
                new Daylabourer
                {
                    EmployeeNo="2019-FI-1343",
                    Name="Adham",
                    Salary=6372,
                }
            };
        }
    }
}
