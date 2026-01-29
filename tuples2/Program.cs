
class Program
{
    public static void Main(string[] args)
    {
        
        var pt = (x: 1, y: 2);
        var subscript = (a: 0, b: 0);
        subscript = pt; 
        Console.WriteLine($"Subscript: {subscript}"); // Imprime (1, 2)

     )
        var namedata = (Name: "morning observation", temp: 17, wind: 4);
        
  
        var person = (firstname: "John", lastname: "Doe");

        var order = (product: "guitar picks", style: "triangle", quantity: 500, unitprice: 0.10);

        Console.WriteLine($"Data: {namedata}");
        Console.WriteLine($"Person: {person.firstname} {person.lastname}");
        Console.WriteLine($"Order: {order}");
    }
}
