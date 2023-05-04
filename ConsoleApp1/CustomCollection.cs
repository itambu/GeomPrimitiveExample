using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CustomCollection<T> : List<T>
    {
        public IEnumerable<T> Backwards()
        {
            int count = Count;

            for(int i = count-1; i >= 0; i--) 
            {
                yield return this[i];
            }
        }
    }
}
