using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Blue", 5);
        //DisplayShapes(square);

        Rectangle rectangle = new Rectangle("Red", 5, 10);
        //DisplayShapes(rectangle);

        Circle circle = new Circle("Yellow", 5);
        //DisplayShapes(circle);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach(Shape shape in shapes)
        {
            DisplayShapes(shape);
        }

    }

    public static void DisplayShapes(Shape shape)
    {
        Console.WriteLine(shape.GetColor());
        Console.WriteLine(shape.GetArea());
    }

}