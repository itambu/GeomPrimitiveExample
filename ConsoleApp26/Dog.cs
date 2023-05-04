using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp26
{
    public class Dog : IOperation
    {
        public void Perform()
        {
            Console.WriteLine("Gav Gav");
        }

        public void OnNewMember(object? sender, IOperation member)
        {
            Perform();
        }
    }
}