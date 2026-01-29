class Program
{
    public static void Main(String[] args)
    {
        string songlyrics="you say goodbye, and I say hello";
        Console.WriteLine(songlyrics.Contains("goodbye"));
        Console.WriteLine(songlyrics.Contains("greetings"));

        Console.WriteLine(songlyrics.StartsWith("you"));
        Console.WriteLine(songlyrics.StartsWith("goodbye"));

        Console.WriteLine(songlyrics.StartsWith("hello"));
        Console.WriteLine(songlyrics.StartsWith("goodbye"));

    }
}