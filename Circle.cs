using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Circle : Shape // Circle inherits from Shape
    {
        int _radius;
        string _name = "Circle";
        double _area;
        
        public Circle(int radius) {
            _radius = radius;
        }

        public override void GetArea()  // Calculate radius
        {
            double area = _radius * _radius * Math.PI;
            _area = area;
            Console.WriteLine($"{_name} area: {area}");
            
        }

        public override void PrintShape()   // Print information
        {
            
            Console.WriteLine($"Shape {_name} have a radius of {_radius} and area of {_area} ");
        }

    }

}
