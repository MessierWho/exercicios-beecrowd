using System.Globalization;

class Program
{
    static void Main()
    {
        double pi = 3.14159;

        string[] inputs = Console.ReadLine().Split();
        double A = double.Parse(inputs[0], CultureInfo.InvariantCulture);
        double B = double.Parse(inputs[1], CultureInfo.InvariantCulture);
        double C = double.Parse(inputs[2], CultureInfo.InvariantCulture);

        double areaTriangulo = (A * C) / 2.0;
        double areaCirculo = pi * Math.Pow(C, 2);
        double areaTrapezio = ((A + B) * C) / 2.0;
        double areaQuadrado = Math.Pow(B, 2);
        double areaRetangulo = A * B;

        Console.WriteLine($"TRIANGULO: {areaTriangulo.ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"CIRCULO: {areaCirculo.ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"TRAPEZIO: {areaTrapezio.ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"QUADRADO: {areaQuadrado.ToString("F3", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"RETANGULO: {areaRetangulo.ToString("F3", CultureInfo.InvariantCulture)}");
    }
}