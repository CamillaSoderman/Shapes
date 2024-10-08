using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Triangle : Shape // Triangle inherits from Shape
    {
        string _name = "Triangle";
        double _area;
        int _side1;
        int _side2;
        int _side3;
        public Triangle( int side1, int side2, int side3 ) 
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public override void GetArea()  // Calculate area of the Triangle
        {
           double area = (_side1 + _side2 + _side3 ) / 2;
            _area = area;
            Console.WriteLine($"{_name} area: {area}");
        }
        public override void PrintShape()   // Print information
        {
            Console.WriteLine($"Shape {_name} have an area of {_area} ");
        }
    }
}
