using System;
using System.Data;

class Program
{
    // Agregamos 'static' para que Main pueda llamarlo directamente
    public static void WorkWithIntegers()
    {
        int a = 5;
        int b=4;
        int c=2;
        int d=a+b*c;
        Console.WriteLine($"{d}");
        d=(a+b)*c;
        Console.WriteLine($"{d}");
        d=(a+b)-6*c+(12*4)/3+12;
        Console.WriteLine($"{d}");
    }
    public static void orderprecedence()
    {
        int a=7;
        int b=4;
        int c=3;
        int d=(a+b)/c;
        int e=(a+b)%c;
        Console.WriteLine($"quotient{d}");
        Console.WriteLine($"remainder{e}");
    }
    public static void maxmin()
    {
        int a=7;
        int b=4;
        int c=3;
        int d=(a+b)/c;
        int e=(a+b)%c;
       int max=int.MaxValue;
       int min=int.MinValue;
       Console.WriteLine($"the range of integers is {min} to {max}");
       int what=max+3;
       Console.WriteLine($"an exmaple of overflow:{what}");
    }

    public static void Main(string[] args)
    {
       WorkWithIntegers();
       orderprecedence();
       maxmin();
    }
}