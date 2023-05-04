using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Vector<T> : IEnumerable<T>
    {
        T x;
        T y;
        T z;

        public Vector(T x, T y, T z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public IEnumerator<T> GetEnumerator()
        {
            yield return x;
            yield return y;
            yield return z;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
