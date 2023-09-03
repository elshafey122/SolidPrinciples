using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
    static class Repository2
    {
        public static IEnumerable<Employee2> LoadEmployees()
        {
            return new List<Employee2>
            {
                new Staff2
                {
                    EmployeeNo="2017-FI-1343",
                    Name="Ali",
                    Salary=13445,
                },
                new Consultant2
                {
                    EmployeeNo="2018-FI-1343",
                    Name="Salah",
                    Salary=9474,
                },
                new Daylabourer2
                {
                    EmployeeNo="2019-FI-1343",
                    Name="Adham",
                    Salary=6372,
                }
            };
        }
    }
}
