using System; // Corregido: Necesario para Console

public class Program
{
    // El cuerpo del record debe ir inmediatamente después de la declaración de parámetros
    public record Point(int x, int y)
    {
        public double slope() => (double)x / (double)y;
    }

    public static void Main(string[] args)
    {
        Point pt3 = new Point(1, 1);
        
        // Uso correcto de 'with' para evolución de estado inmutable
        var pt4 = pt3 with { y = 10 };
        
        Console.WriteLine($"The two points are {pt3} and {pt4}");

        double sloperesult = pt4.slope();
        Console.WriteLine($"The slope of {pt4} is {sloperesult}");
    }
}