using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double MEDIA = ((A * 3.5) + (B * 7.5)) / 11;
        
        Console.WriteLine($"MEDIA = {MEDIA:F5}", CultureInfo.InvariantCulture);
    }
}