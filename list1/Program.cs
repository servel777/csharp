class Porgram
{
    public static void Main(String[] args)
    {
       List<string> names =["<names>","ana","felipe"];
       names.Add("Maria");
       names.Add("Bill");
       names.Add("Ana");
       foreach(var name in names)
        {
            Console.WriteLine($"hello {name.ToUpper()}");
        }

        Console.WriteLine($"my name is {names[0]}");
        Console.WriteLine($"I've added {names[2]} ane {names[3]} to the list");
        Console.WriteLine($"the list has {names.Count} people in it");

        var index=names.IndexOf("felipe");
        if (index == -1)
        {
            Console.WriteLine($"when an item is not found, indexof return {index}");

        }
        else
        {
            Console.WriteLine($"the name {names[index]} is at index {index} ");
        }
        index=names.IndexOf("not found");
        if (index == -1)
        {
            Console.WriteLine($"when an item is not found index of return {index}");
        }
        else
        {
            Console.WriteLine($"the name {names[index]} is at index {index}");
        }

        names.Sort();
        foreach(var name in names)
        {
            Console.WriteLine($"hello {name.ToUpper()}");
        }
    }
}