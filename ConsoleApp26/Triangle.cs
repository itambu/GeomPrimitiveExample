using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    public class Triangle
    {
        public Point A { get; private set; }
        public Point B { get; private set; }
        public Point C { get; private set; }

        public void Move(double x, double y)
        {
            A.Move(x, y);
            B.Move(x, y);
            C.Move(x, y);
        }

        public void Rotate(double angle)
        {
            A.Rotate(angle);
            B.Rotate(angle);
            C.Rotate(angle);
        }

        public Triangle(Point a, Point b, Point c)
        {
            A = a; 
            B = b; 
            C = c;
        }

        public double Perimeter
        {
            get 
            {
                return Point.GetLength(A,B) 
                    + Point.GetLength(B,C) 
                    + Point.GetLength(C,A);
            }
        }
    }
}
