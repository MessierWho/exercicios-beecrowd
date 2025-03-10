using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US");

        string[] p1 = Console.ReadLine().Split();
        string[] p2 = Console.ReadLine().Split(); 
        double x1 = double.Parse(p1[0]);
        double y1 = double.Parse(p1[1]);
        double x2 = double.Parse(p2[0]);
        double y2 = double.Parse(p2[1]);

        double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        Console.WriteLine($"{distancia:F4}");
    }
}