using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    public class Manager : Employee
    {
        protected override void DoWork(bool arg)
        {
            //base.DoWork();
            Console.WriteLine("Manager is working");
        }

        public Manager(string name) : base(name)
        {
        }
    }
}
