using System;
using System.Runtime.CompilerServices;

class Program
{
    // Agregamos 'static' para que Main pueda llamarlo directamente

    public static void Main(string[] args)
    {
      var pt=(x:1,y:2);
      var slope=(double)pt.y/(double)pt.x;
      Console.WriteLine($"a line from the origin to the point {pt} has slope of {slope}");

      pt.x=pt.x+5;
      Console.WriteLine($"the point ins now at {pt}");

      var pt2=pt with {y=10};
      Console.WriteLine($"the point 'pt2' is at {pt2}");
    }
}