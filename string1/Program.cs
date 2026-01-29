class Program
{
    public static void Main(String[] args)
    {
        string sayhello="hello world!";
        Console.WriteLine(sayhello);
        sayhello=sayhello.Replace("hello","greetings");
        Console.WriteLine(sayhello);
        Console.WriteLine(sayhello.ToUpper());
        Console.WriteLine(sayhello.ToLower());
    }
}