using System;

namespace PatternMatting
{
    class Program
    {
        static void Main(string[] args)
        {
            var cidadesVisitadas = new object[] { "10", 2, null, Guid.NewGuid() };

            foreach (var item in cidadesVisitadas)
            {
                if (item != null) //is not
                {
                    if (item.GetType() != null) //string
                        Console.WriteLine("achei o 10");
                    else
                        Console.WriteLine($"{item.GetType()} {item}");
                }
                else
                {
                    Console.WriteLine("obj null");
                }
            }
        }

        public static double ComputeArea(object shape)
        {
            switch (shape)
            {
                case Square s when s.Side == 0:
                case Circle c when c.Radius == 0:
                case Triangle t when t.Base == 0 || t.Height == 0:
                case Rectangle r when r.Length == 0 || r.Height == 0:
                    return 0;

                case Square s:
                    return s.Side * s.Side;
                case Circle c:
                    return c.Radius * c.Radius * Math.PI;
                case Triangle t:
                    return t.Base * t.Height / 2;
                case Rectangle r:
                    return r.Length * r.Height;
                case null:
                    throw new ArgumentNullException(paramName: nameof(shape), message: "Shape must not be null");
                default:
                    throw new ArgumentException(
                        message: "shape is not a recognized shape",
                        paramName: nameof(shape));
            }
        }
    }

    public class Square
    {
        public double Side { get; }

        public Square(double side)
        {
            Side = side;
        }
    }
    public class Circle
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }
    }
    public struct Rectangle
    {
        public double Length { get; }
        public double Height { get; }

        public Rectangle(double length, double height)
        {
            Length = length;
            Height = height;
        }
    }
    public class Triangle
    {
        public double Base { get; }
        public double Height { get; }

        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
        }
    }
}
