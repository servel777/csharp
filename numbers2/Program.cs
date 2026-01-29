using System;

class Program
{
    // Agregamos 'static' para que Main pueda llamarlo directamente
    public static void WorkWithIntegers()
    {
        int a = 18;
        int b = 6;
        
        int c = a + b;
        Console.WriteLine($"Suma: {c}");
        
        c = a - b;
        Console.WriteLine($"Resta: {c}");
        
        c = a * b;
        Console.WriteLine($"Multiplicación: {c}");
        
        c = a / b;
        Console.WriteLine($"División: {c}");
    }

    public static void Main(string[] args)
    {
       WorkWithIntegers();
    }
}