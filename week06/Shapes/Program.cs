using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>
        {
            new Square("Rojo", 5),
            new Rectangle("Azul", 4, 6),
            new Circle("Verde", 3)
        };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"{shape.GetColor()} área: {shape.GetArea()}");
        }
    }
}
