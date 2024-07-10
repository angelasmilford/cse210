using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(2, "Green");


        Rectangle rectangle = new Rectangle(1, 3, "Black");


        Circle circle = new Circle(11, "Blue");


        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();
            
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}