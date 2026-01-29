using System;

class Program
{
    // Agregamos 'static' para que Main pueda llamarlo directamente
    public static void WorkWithIntegers()
    {
        double a=5;
        double b=4;
        double c=2;
        double d=(a+b)/c;
        Console.WriteLine($"{d}");

        double max=double.MaxValue;
        double min=double.MinValue;

        Console.WriteLine($"the range of double is{min} to {max}");

        double third=1.0/3.0;
        Console.WriteLine(third);
    }

    public static void Main(string[] args)
    {
       WorkWithIntegers();
    }
}