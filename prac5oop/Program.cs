using System;
using static System.Math;
using static System.Console;

abstract class RegularPolygon
{
    protected int sides;
    protected double sideLength;

    public RegularPolygon(int sides, double sideLength)
    {
        this.sides = sides;
        this.sideLength = sideLength;
    }

    public abstract void Create();
    public virtual double GetPerimeter()
    {
        return sides * sideLength;
    }
    public abstract double GetArea();
    public virtual double GetAngle()
    {
        return 180.0 * (sides - 2) / sides;
    }
}

class Triangle : RegularPolygon
{
    public Triangle(double sideLength) : base(3, sideLength) { }

    public override void Create()
    {
        WriteLine("Створено трикутник, у якого довжина сторони дорівнює {0}", sideLength);
    }

    public override double GetArea()
    {
        return 0.5 * sideLength * sideLength * Sqrt(3) / 4;
    }
}

class Square : RegularPolygon
{
    public Square(double sideLength) : base(4, sideLength) { }

    public override void Create()
    {
        WriteLine("Створено квадрат, у якого довжина сторони дорівнює {0}", sideLength);
    }

    public override double GetArea()
    {
        return sideLength * sideLength;
    }
}

class Octagon : RegularPolygon
{
    public Octagon(double sideLength) : base(8, sideLength) { }

    public override void Create()
    {
        WriteLine("Створено восьмикутник, у якого довжина сторони дорівнює {0}", sideLength);
    }

    public override double GetArea()
    {
        return 2 * (1 + Sqrt(2)) * sideLength * sideLength;
    }
}

class Program
{
    static void Main(string[] args)
    {
        RegularPolygon[] polygons = new RegularPolygon[]
        {
            new Triangle(5),
            new Square(6),
            new Octagon(4),
        };

        foreach (RegularPolygon polygon in polygons)
        {
            polygon.Create();
            WriteLine("Периметр: {0}", polygon.GetPerimeter());
            WriteLine("Площа: {0}", polygon.GetArea());
            WriteLine("Кут: {0} градусов\n", polygon.GetAngle());
        }
    }
}

