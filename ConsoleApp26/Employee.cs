using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    public abstract class Employee : Person
    {
        public string Company { get; set; }

        public void DoWork()
        {
            Console.WriteLine($"{Name}");
            DoWork(true);
        }

        protected abstract void DoWork(bool arg);
       

        public Employee(string name) : base(name)
        {
        }
    }
}
