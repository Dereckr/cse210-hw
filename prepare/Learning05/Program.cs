using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square("blue",2);
        Console.WriteLine(square1.GetColor());
        Console.WriteLine(square1.GetArea());

        Rectangle rectangle1 = new Rectangle("red",4,2);
        Console.WriteLine(rectangle1.GetColor());
        Console.WriteLine(rectangle1.GetArea());

        Circle circle1 = new Circle("yellow",5);
        Console.WriteLine(circle1.GetColor());
        Console.WriteLine(circle1.GetArea());

        List<Shape> _shapes = new List<Shape>();
        _shapes.Add(square1);
        _shapes.Add(rectangle1);
        _shapes.Add(circle1);
        
        foreach (Shape s in _shapes)
        {
        Console.WriteLine(s.GetColor());
        Console.WriteLine(s.GetArea());
        }


    }
}