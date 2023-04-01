using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp26
{
    public class Department
    {
        public string Name { get; set; }
        public Employee TeamLead { get; set; }
        public List<Employee> Employees { get; set; }

        public void CleanPremice()
        {
            foreach (Employee emp in Employees)
            {
                emp.DoWork();
            }
            TeamLead.DoWork();
        }

    }
}