namespace Shapes
{
    // Programmer   : Camilla Söderman
    // Program      : Fullstack .NET
    // Course       : Promgrammering med C# och .NET
    // Lab 5        : Grunderna OOP
    internal class Program
    {
        static void Main(string[] args)
        {
            int radius1 = 5;
            int radius2 = 6;
            Circle circle = new Circle(radius1);            //Create new circle
            Circle circle2 = new Circle(radius2);           //Create new circle
            Triangle triangle1 = new Triangle(3, 4, 5);     //Create new triangle   
            Triangle triangle2 = new Triangle(5, 5, 5);     //Create new triangle

            circle.GetArea();           // Call for area
            circle2.GetArea();
            triangle1.GetArea();
            triangle2.GetArea();

            circle.PrintShape();        // Print info
            circle2.PrintShape();
            triangle1.PrintShape();
            triangle2.PrintShape();
            Console.ReadKey();
            


        }
    }
}
