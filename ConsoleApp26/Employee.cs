using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    public abstract class Employee : Person, IOperation
    {
        public string Company { get; set; }

 
        protected abstract void DoWork(bool arg);

        public void Perform()
        {
            Console.WriteLine($"{Name}");
            DoWork(true);
        }

        public Employee(string name) : base(name)
        {
        }
    }
}
