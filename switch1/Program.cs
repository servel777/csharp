class Program
{
    public static void Main(string[] args)
    {
        int n=GetNumber();

        if(n<20)
            Console.WriteLine("n is less than 20");
        else if(n<10)
            Console.WriteLine("n is less than 10");
        else
            Console.WriteLine("n is greater than 20");
    }
    static int GetNumber()
    {
        return 23;
    }
}
