public class Program
{
    public static void Main(String[] args)
    {
        for(int row = 1; row < 11; row++)
        {
            for(char column = 'a'; column < 'k'; column++)
            {
                Console.WriteLine($"the cell is ({row},{column})");
            }
        }
    }
}