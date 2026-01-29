using System;
using System.Formats.Asn1;

class Program
{
    // Agregamos 'static' para que Main pueda llamarlo directamente
    public static void WorkWithIntegers()
    {
        double a=1.0;
        double b=3.0;

        Console.WriteLine(a/b);

        decimal c=1.0M;
        decimal d=3.0M;

        Console.WriteLine(c/d);

        decimal min=decimal.MinValue;
        decimal max=decimal.MaxValue;

        Console.WriteLine($"the range of the decimal type is {min} to {max}");
    }

    public static void area()
    {
        double radius=2.50;
        double area=Math.PI*radius*radius;
        Console.WriteLine(area);
    }

    public static void Main(string[] args)
    {
       WorkWithIntegers();
       area();
    }
}