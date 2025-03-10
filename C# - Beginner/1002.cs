using System;

class Program
{
    static void Main()
    {
        const double PI = 3.14159;
        
        double raio = double.Parse(Console.ReadLine());
        
        double area = PI * Math.Pow(raio, 2);

        Console.WriteLine($"A={area:F4}");
    }
}