using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo culture = CultureInfo.InvariantCulture;

        string nomeVendedor = Console.ReadLine();
        double salarioFixo = double.Parse(Console.ReadLine(), culture);
        double totalVendas = double.Parse(Console.ReadLine(), culture);

        double comissao = totalVendas * 0.15;

        double totalReceber = salarioFixo + comissao;

        Console.WriteLine($"TOTAL = R$ {totalReceber.ToString("F2", culture)}");
    }
}