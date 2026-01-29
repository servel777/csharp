using System;

class Ejemplo1
{
    public static bool Or(bool left, bool right) => (left, right) switch
    {
        (true, true) => true,
        (true, false) => true,
        (false, true) => true,
        (false, false) => false,
    };

    public static bool And(bool left, bool right) => (left, right) switch
    {
        (true, true) => true,
        (true, false) => false,
        (false, true) => false,
        (false, false) => false,
    };

    public static bool Xor(bool left, bool right) => (left, right) switch
    {
        (true, true) => false,
        (true, false) => true,
        (false, true) => true,
        (false, false) => false,
    };

    // Este método es una forma simplificada del AND original
    public static bool ReduceAnd(bool left, bool right) => (left, right) switch
    {
        (true, true) => true,
        (_, _) => false, // El descarte captura cualquier otra combinación
    };

    public static void Main(string[] args)
    {
        // Definimos las variables de prueba
        bool t = true;
        bool f = false;

        Console.WriteLine("TABLAS DE VERDAD");
        Console.WriteLine("---------------------------------");
        
        // Probando OR
        Console.WriteLine($"OR:  {t} | {f} = {Or(t, f)}");
        
        // Probando AND y ReduceAnd (deben dar el mismo resultado)
        Console.WriteLine($"AND: {t} & {t} = {And(t, t)}");
        Console.WriteLine($"ReduceAnd: {t} & {f} = {ReduceAnd(t, f)}");
        
        // Probando XOR
        Console.WriteLine($"XOR: {t} ^ {t} = {Xor(t, t)} (Iguales da Falso)");
        Console.WriteLine($"XOR: {t} ^ {f} = {Xor(t, f)} (Diferentes da Verdadero)");
        
        Console.WriteLine("---------------------------------");
    }
}