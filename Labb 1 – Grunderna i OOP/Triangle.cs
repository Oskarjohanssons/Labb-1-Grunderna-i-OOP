using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_1___Grunderna_i_OOP
{
    internal class Triangle
    {
        double Side1;
        double Side2;
        double Side3;
        
        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public void DisplayArea()
        {
            Console.WriteLine($"Arean på en triangel med sidorna 30,30 och 50 blir: {GetArea()}");
        }


        public double GetArea()
        {
            double side = (Side1 + Side2 + Side3) / 2.0;
            return Math.Round(Math.Sqrt(side * (side - Side1) * (side - Side2) * (side - Side3)), 1);

        }

    }
}
