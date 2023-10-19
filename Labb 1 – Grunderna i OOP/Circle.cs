using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_1___Grunderna_i_OOP
{
    class Circle
    {
        float Pi = 3.141f;
        int Radius = 5;

        public Circle(int radius)
        {
            Radius = radius;
        }

        public void DisplayVolume()
        {
            Console.WriteLine($"Om cirkeln var en boll/svär så hade volymen varit: {GetVolume()} ");
        }

        public void DisplayArea()
        {
            Console.WriteLine($"Arean på cirkeln är: {GetArea()}");
        }

        public void DisplayCircumference()
        {
            Console.WriteLine($"Omkretsen på cirkeln är: {GetCircumference()}");
        }

        public float GetArea()
        {
            float area = Radius * Radius * Pi;
            return area;
        }
        public float GetCircumference()
        {
            float circumference = 2 * Pi * Radius;
            return circumference;
        }

        public double GetVolume()
        {
            double volume = 4 * Pi * Math.Pow(Radius, 3.0) / 3;
            return volume;
        }
    }
}
