using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Circle(5, "Red"));
        shapes.Add(new Rectangle(4, 6, "Blue"));
        shapes.Add(new Square(3, "Green"));

        // Iterate through the list of shapes and print their areas and colors
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}, Area: {shape.CalculateArea()}");
        }
    }
}