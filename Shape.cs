using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Shape // Parent class
    {
        string _name { get; set; }
        double _area;
        public Shape() { 
        }

        public virtual void GetArea()
        {

        }
        public virtual void PrintShape()  // Print information
        {
            Console.WriteLine($"Shape {_name} have an area of {_area} ");
        }
    }
}
