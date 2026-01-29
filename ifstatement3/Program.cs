using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static  void exploredif(){
        int a=5;
        int b=3;
        if (a + b > 10)
        {
            Console.WriteLine("the answer is greater than 10");
        }
        else
        {
            Console.WriteLine("the answer is not greater than 10");
        }

        int c=4;
        if ((a + b + c > 10)&& (a > b)){
            Console.WriteLine("the answer is greater than 10");
            Console.WriteLine("and the first number is greater then second");
        }
        else
        {
            Console.WriteLine("the answer is not greater than 10");
            Console.WriteLine("and the first number is not greater then second");
        }
         if ((a + b + c > 10)|| (a > b)){
            Console.WriteLine("the answer is greater than 10");
            Console.WriteLine("and the first number is greater then second");
        }
        else
        {
            Console.WriteLine("the answer is not greater than 10");
            Console.WriteLine("and the first number is not greater then second");
        }
    }
    public static void Main(String[] args)
    {
            exploredif();
    }
}