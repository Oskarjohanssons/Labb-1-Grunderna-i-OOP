using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_1___Grunderna_i_OOP
{
    internal class Triangle
    {
        double _side1;
        double _side2;
        double _side3;
        
        public Triangle(double side1, double side2, double side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public double getArea()
        {
            double side = (_side1 + _side2 + _side3) / 2.0;
            return Math.Round(Math.Sqrt(side * (side - _side1) * (side - _side2) * (side - _side3)), 1);

        }

    }
}
