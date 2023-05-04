using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp26
{
    public class ReportingTeamLead : TeamLead, IOperation
    {
        public ReportingTeamLead(string name) : base(name)
        {
        }

        void IOperation.Perform()
        {
            Console.WriteLine("Super teamlead");
            DoWork(true);
        }

        protected override void DoWork(bool arg)
        {
            base.DoWork(true);
            Console.WriteLine("Teamlead has sent a report");
        }
    }
}