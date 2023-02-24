// See https://aka.ms/new-console-template for more information
using ConsoleApp26;

Point p = new Point(3, 7);

p.Move(4, 5);
p.Rotate(0.03);

for (int i = 0; i < 100; i++)
{
    p.Rotate(0.03);
    Console.WriteLine($"({p.X}, {p.Y})");
}
