class Porgram
{
    public static void Main(String[] args)
    {
        int a=5;
        int b=3;
        int c=4;
        if ((a + b + c > 10) && (a == b))
        {
            Console.WriteLine("the answer is greater than 10.");
            Console.WriteLine("and the first number equal to the second");
        }

        else
        {
             Console.WriteLine("the answer is not greater than 10");
            Console.WriteLine("or the firts number is not equal to the second");
        }
           
    }
}