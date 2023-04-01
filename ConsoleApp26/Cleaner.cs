using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp26
{
    public class Cleaner : Employee
    {
        public Cleaner(string name) : base(name)
        {

        }

        protected override void DoWork(bool arg)
        {
            Console.WriteLine("Cleaner is working");
        }
    }
}