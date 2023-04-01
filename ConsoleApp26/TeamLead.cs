using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp26
{
    public class TeamLead : Manager
    {
        protected override void DoWork(bool arg)
        {
            base.DoWork(true);
            Console.WriteLine("TeamLead has controlled the operations");
        }

        public TeamLead(string name) : base(name)
        {
        }
    }
}