class Program
{
    public static void Main(string[] args)
    {
        string greeting="      hello world";
        Console.WriteLine($"[{greeting}]");

        string trimmedgreeting=greeting.TrimStart();
        Console.WriteLine($"[{trimmedgreeting}]");
        trimmedgreeting=greeting.TrimEnd();
        Console.WriteLine($"[{trimmedgreeting}]");
        trimmedgreeting=greeting.Trim();
        Console.WriteLine($"[{trimmedgreeting}]");
    }
}