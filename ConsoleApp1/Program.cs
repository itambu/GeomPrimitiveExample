// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");


List<int> ints = new List<int>() { 1, 2, 4, 7, 2 };

//-----------------------------------------------------

IEnumerator<int> enumerator = ints.GetEnumerator();

using (enumerator)
{
    while (enumerator.MoveNext())
    {
        var c = enumerator.Current;

        Console.WriteLine(c);
    }
}


var cl = new CustomCollection<int>() { 2, 4, 5 };

//--------------------------------------------------------
foreach (int c in cl.Backwards())
{ 
    Console.WriteLine(c);
}

//---------------------------------------------------------

var v = new Vector<double>(1, 2, 3.5);


foreach(var d in v)
{
    Console.WriteLine(d);
}