using System;
using System.Collections.Generic; // Necesario para List e IEnumerable

class Ejemplo1
{
    public static void Main(string[] args)
    {
        // Collection expressions corregidos
        int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        List<string> names = ["alice", "bob", "charlie", "david"];
        IEnumerable<int> morenumbers = [.. numbers, 11, 12, 13];
        IEnumerable<string> empty = [];

        // Índices: names[1] es "bob", names[^1] es "david"
        string second = names[1];
        string last = names[^1];

        // ERROR CORREGIDO: El operador de rango [0..5] devuelve un subarray, 
        // por lo tanto la variable debe ser un array (int[]), no un solo int.
        int[] smallnumbers = numbers[0..5];

        Console.WriteLine($"Segundo: {second}");
        Console.WriteLine($"Último: {last}");
        
        // Para imprimir un array no basta con Console.WriteLine, usamos string.Join
        Console.WriteLine($"Rango (0-5): {string.Join(", ", smallnumbers)}");
    }
}