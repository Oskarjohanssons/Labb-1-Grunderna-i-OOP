using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_1___Grunderna_i_OOP
{
    class Circle
    {
        float _pi = 3.141f;
        int _Radius = 5;

        public Circle(int radius)
        {
            _Radius = radius;
        }


        public void getArea()
        {
            float Area = _Radius * _Radius * _pi;
            Console.WriteLine($"Arean på cirkeln är: {Area}");
        }
        public void getCircumference()
        {
            float Circumference = 2 * _pi * _Radius;
            Console.WriteLine($"Omkretsen på cirkeln är: {Circumference}");
        }

        public void getVolume()
        {
            double Volume = 4 * _pi * Math.Pow(_Radius, 3.0) / 3;
            Console.WriteLine($"Om cirkeln var en boll/svär så hade volymen varit: {Volume} " );
        }
    }
}
