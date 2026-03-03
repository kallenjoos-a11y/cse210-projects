using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square square = new Square("greeen", 4);
        shapes.Add(square);
        Rectangle rectangle = new Rectangle("purple", 4, 3);
        shapes.Add(rectangle);
        Circle circle = new Circle("blue", 4);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
        }
       
    }
}