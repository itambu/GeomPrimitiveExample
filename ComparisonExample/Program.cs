using System.Reflection.Metadata.Ecma335;

internal class Program
{
    private static void Main(string[] args)
    {
        int a = 10, b = 10;

        object a1 = new object();
        object b1 = new object();

        MyStruct s1 = new MyStruct() { Id = 1, Name = "aaaaa" };
        MyStruct s2 = new MyStruct() { Id = 2, Name = "bbbbb" };


        Console.WriteLine( $"{a1.GetHashCode()} {b1.GetHashCode()}" );

        List<MyStruct> myStructs = new List<MyStruct>();

        myStructs.Sort(new StComparer());

        var comparer = new IdComparer();
        var comparer2 = new NameComparer();


        int? position = Find(myStructs, s1, comparer2);



    }

    static int? Find<T>(List<T> list, T obj, IEqualityComparer<T> comparer)
    {
        for(int i = 0; i < list.Count; i++)
        {
            if (comparer.Equals(list[i], obj) )
            {
                return i;
            }
        }
        return null;
    }

    class MyStruct
    {
        public int Id { get; init; }
        public string? Name { get; init; }

        public override bool Equals(object? obj)
        {
            if (Object.ReferenceEquals(this, obj))
            {
                return true;
            }
            else
            {
                MyStruct? temp = obj as MyStruct;
                if (temp != null)
                {
                    return temp.Id == this.Id && this.Name == temp.Name;
                }
                else
                { return false; }
            }
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode() ^ Name!.GetHashCode();
        }

    }

    class NameComparer : IEqualityComparer<MyStruct>
    {
        bool IEqualityComparer<MyStruct>.Equals(MyStruct? x, MyStruct? y)
        {
            if (Object.ReferenceEquals(x, y))
            {
                return true;
            }
            else
            {
                return (x != null && y != null) ? x.Name == y.Name : false;
            }
        }

        int IEqualityComparer<MyStruct>.GetHashCode(MyStruct obj)
        {
            throw new NotImplementedException();
        }
    }

    class IdComparer : IEqualityComparer<MyStruct>
    {
        bool IEqualityComparer<MyStruct>.Equals(MyStruct? x, MyStruct? y)
        {
            if (Object.ReferenceEquals(x, y) )
            {
                return true;
            }
            else
            {
                return (x != null && y != null) ? x.Id == y.Id : false;
            }
        }

        int IEqualityComparer<MyStruct>.GetHashCode(MyStruct obj)
        {
            return obj != null ? obj.Id : 0;
        }
    }

    class StComparer : Comparer<MyStruct>
    {
        public override int Compare(MyStruct? x, MyStruct? y)
        {
            if (Object.ReferenceEquals(x, y))
            {
                return 0;
            }
            else
            {
                string? t1 = (x != null) ? x.Name : null;
                string? t2 = (y != null) ? y.Name : null;
                return (t1 != t2) ? t1!=null ? t1.CompareTo(t2) : t2!.CompareTo(t1) : 0;
            }
        }
    }
}