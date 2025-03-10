using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double N = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        int valor = (int)Math.Round(N * 100);

        int[] notas = { 10000, 5000, 2000, 1000, 500, 200 };
        int[] moedas = { 100, 50, 25, 10, 5, 1 };

        Console.WriteLine("NOTAS:");

        foreach (int nota in notas)
        {
            Console.WriteLine($"{valor / nota} nota(s) de R$ {(nota / 100.0):F2}");
            valor %= nota;
        }

        Console.WriteLine("MOEDAS:");

        foreach (int moeda in moedas)
        {
            Console.WriteLine($"{valor / moeda} moeda(s) de R$ {(moeda / 100.0):F2}");
            valor %= moeda;
        }
    }
}