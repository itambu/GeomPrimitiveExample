using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp26
{
    public delegate int BinaryCompare<T>(T? a, T? b);

    public delegate bool MyPredicate<T>(T d);

    public static class Extensions
    {
        public static IEnumerable<T> SortByName<T>(this IEnumerable<T> source, BinaryCompare<T> comparer )
        {
            if (comparer is null)
            {
                throw new ArgumentNullException(nameof(comparer));
            }

            var list = new List<T>(source);
            for (int i = 0; i < list.Count - 1; i++)
            {
                var t = i;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (comparer!(list[j], list[t]) < 0)
                    {
                        t = j;
                    }

                    if (comparer?.Invoke(list[j], list[t]) < 0)
                    {
                        t = j;
                    }

                }
                var c = list[t];
                list[t] = list[i];
                list[i] = c;
            }

            return list;
        }

        public static int IntComparer(int a, int b)
        {
            return a.CompareTo(b);
        }


        public static void c1()
        {
            Console.WriteLine("d1");
        }
        public static void c2()
        {
            Console.WriteLine("d2");
        }
        public static void c3()
        {
            Console.WriteLine("d3");
        }

        public static IEnumerable<T> OurWhereMethod<T>(IEnumerable<T>? source, 
            MyPredicate<T>? predicate)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (predicate == null) throw new ArgumentNullException("predicate");

            foreach(var c in source)
            {
                if ( predicate.Invoke(c) )
                {
                    yield return c;
                }
            }
        }

        public static bool HasMoreThan2Person(Department d)
        {
            return d.Count > 2;
        }
    }
}