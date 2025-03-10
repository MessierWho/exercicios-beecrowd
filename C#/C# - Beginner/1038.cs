using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main()
    {
        var precos = new Dictionary<int, double>
        {
            {1, 4.00},
            {2, 4.50},
            {3, 5.00},
            {4, 2.00},
            {5, 1.50}
        };
        string[] entrada = Console.ReadLine().Split(' ');
        int codigo = int.Parse(entrada[0]);
        int quantidade = int.Parse(entrada[1]);

        double total = precos[codigo] * quantidade;

        Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}