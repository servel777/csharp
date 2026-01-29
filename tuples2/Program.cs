
class Program
{
    public static void Main(string[] args)
    {
        // 1. Asignación de tuplas (Funciona porque los tipos coinciden: int, int)
        var pt = (x: 1, y: 2);
        var subscript = (a: 0, b: 0);
        subscript = pt; 
        Console.WriteLine($"Subscript: {subscript}"); // Imprime (1, 2)

        // 2. Namedata (Correcto)
        var namedata = (Name: "morning observation", temp: 17, wind: 4);
        
        // 3. Person (Corregido: faltaba asignar valores iniciales vacíos o específicos)
        var person = (firstname: "John", lastname: "Doe");

        // 4. Order (Corregido: tenías comas donde deberían ir dos puntos y errores de dedo)
        // Las tuplas usan 'nombre: valor'
        var order = (product: "guitar picks", style: "triangle", quantity: 500, unitprice: 0.10);

        Console.WriteLine($"Data: {namedata}");
        Console.WriteLine($"Person: {person.firstname} {person.lastname}");
        Console.WriteLine($"Order: {order}");
    }
}