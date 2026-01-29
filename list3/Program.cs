class Porgram
{
    public static void Main(String[] args)
    {
       List<int>fibonaccinumbers=[1,1];

        while (fibonaccinumbers.Count < 20)
        {
            var prevoius=fibonaccinumbers[fibonaccinumbers.Count-1];
            var prevoius2=fibonaccinumbers[fibonaccinumbers.Count-2];

            fibonaccinumbers.Add(prevoius+prevoius2);
        }

        foreach(var item in fibonaccinumbers)
        {
            Console.WriteLine(item);
        }
    }
}