// See https://aka.ms/new-console-template for more information
using ConsoleApp26;


// creating object model
Manager manager = new Manager("ddddd");
Cleaner cleaner = new Cleaner("gggggg");

List<Employee> list = new List<Employee>()
{
    cleaner,
    new Cleaner("Bob"),
    manager,
};

var dept = new Department()
{
    Name = "fhdjfhdjfd",
    TeamLead = new ReportingTeamLead("Bart"),
    Employees = list
};

// process executing

dept.CleanPremice();







