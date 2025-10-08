using System;
using System.Collections.Generic;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Polymorphism Demonstration: Shape Areas ---");
            
            Square mySquare = new Square("Red", 7.0);
            Console.WriteLine($"--- Testing Square ---");
            Console.WriteLine($"Color: {mySquare.GetColor()}, Area: {mySquare.GetArea():F2}"); 
            
            Rectangle myRectangle = new Rectangle("Blue", 4.0, 9.0);
            Console.WriteLine($"--- Testing Rectangle ---");
            Console.WriteLine($"Color: {myRectangle.GetColor()}, Area: {myRectangle.GetArea():F2}"); 

            Circle myCircle = new Circle("Yellow", 5.0);
            Console.WriteLine($"--- Testing Circle ---");
            Console.WriteLine($"Color: {myCircle.GetColor()}, Area: {myCircle.GetArea():F2}"); 
            
            Console.WriteLine();

            List<Shape> shapes = new List<Shape>();

            shapes.Add(mySquare);
            shapes.Add(myRectangle);
            shapes.Add(myCircle);
            shapes.Add(new Square("Green", 8.0));
            shapes.Add(new Circle("Purple", 2.5));

            Console.WriteLine("--- Polymorphism Test: Iterating Through List<Shape> ---");

            foreach (Shape shape in shapes)
            {
                string type = shape.GetType().Name;
                double area = shape.GetArea();

                Console.WriteLine($"Shape: {type,-10} | Color: {shape.GetColor(),-6} | Area: {area:F2}");
            }

            Console.WriteLine("\n--- Program Complete ---");
        }
    }
}