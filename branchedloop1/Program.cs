using System.Globalization;

public class Program
{
    public static void Main(String[] args)
    {
        int sum=0;
        for(int number = 1; number < 21; number++)
        {
            if (number % 3 == 0)
            {
                sum=sum+number;
            }
        }
        Console.WriteLine($"the sum is {sum}");
    }
}