using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp26
{
    public class ReportingTeamLead : TeamLead
    {
        public ReportingTeamLead(string name) : base(name)
        {
        }

        protected override void DoWork(bool arg)
        {
            base.DoWork(true);
            Console.WriteLine("Team has sent a report");
        }
    }
}