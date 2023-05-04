// See https://aka.ms/new-console-template for more information
using ConsoleApp26;


// creating object model
Manager manager = new Manager("ddddd");
Cleaner cleaner = new Cleaner("gggggg");

List<IOperation> list = new List<IOperation>()
{
    cleaner,
    new Cleaner("Bob"),
    manager,
    new Dog()
};

TeamLead lead = new ReportingTeamLead("Bart");

Console.WriteLine("-------------------------------------------");
((IOperation)lead).Perform();


Console.WriteLine("-------------------------------------------");

IEnumerable<Department> depts = new List<Department>() { new Department("fsagfsa", lead, list) };

int count_limit = 6;

MyPredicate<Department> predicate = delegate (Department d)
{
    return d.Count > count_limit;
};

//MyPredicate<Department> predicate1 = d => { return d.Count > count_limit; };

// z = x*x + y*y;


// T Func<T>(T x, T y)
Func<double, double, double> s = (x, y) => x * x + y * y;

Console.WriteLine(s(1, 1));

var result = Extensions.OurWhereMethod(depts, 
    Extensions.HasMoreThan2Person);

var result1 = Extensions.OurWhereMethod(depts, d => d.Count > count_limit);


foreach (Department dept in result1)
{
    Console.WriteLine(dept.Name);
}


var list2 = new List<int>() { 2, 3, 4, 5, 10, 1, -3 };
var res2 = from x in list2
           where x > 3
           select x * x;

int startFrom = 10;

int pageNumber = 10;

var res3 = list2.Where(x => x > 3)
    .Select(x => new { Source = x, Square = x * x })
    .Skip(startFrom)
    .Take(pageNumber);

foreach (var i in res3)
{
    Console.WriteLine($"{i.Source}");
}


//

// event example
// event model linking
Dog d = new();
Department dept1 = depts.First();
dept1.AfterAddNew += d.OnNewMember;

Dog d1 = new Dog();
dept1.AfterAddNew += d.OnNewMember;

// microprocess -----------------------------------

dept1.Add(new Cleaner("Bob"));

//-------------------------------------------------

//dept1.AddNew = null;
dept1.AfterAddNew -= d.OnNewMember;


//-------------------------------------------------
Console.WriteLine("After changing");
dept1.Add(new Cleaner("Bob"));

Console.WriteLine();








