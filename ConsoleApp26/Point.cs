using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    public class Point
    {
        private double x;
        private double y;




        public double X
        {
            get 
            { 
                return x; 
            }
            
            set 
            { 
                x = value; 
            }
        }

        public double Y { get => y; private set => y = value; }

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public Point()
        {
            this.Y = 1;
            this.Y = 1;
        }

        public void Move(double _x, double _y)
        {
            x += _x;
            y += _y;
        }

        public void Rotate(double alfa)
        {
            double sinA = Math.Sin(alfa);
            double cosA = Math.Cos(alfa);

            double _x = X * cosA - y * sinA;
            double _y = X * sinA + y * cosA;

            X = _x;
            Y = _y;
        }

        public static double GetLength(Point a, Point b)
        {
            double dx = b.X - a.X;
            double dy = b.Y - a.Y;
            return dx * dx + dy * dy;
        }
    }
}
