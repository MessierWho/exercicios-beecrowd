using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo culture = CultureInfo.InvariantCulture;

        string[] dadosPeca1 = Console.ReadLine().Split();
        int codigoPeca1 = int.Parse(dadosPeca1[0]);
        int numPecas1 = int.Parse(dadosPeca1[1]);
        double valorUnitarioPeca1 = double.Parse(dadosPeca1[2], culture);

        string[] dadosPeca2 = Console.ReadLine().Split();
        int codigoPeca2 = int.Parse(dadosPeca2[0]);
        int numPecas2 = int.Parse(dadosPeca2[1]);
        double valorUnitarioPeca2 = double.Parse(dadosPeca2[2], culture);

        double valorTotalPeca1 = numPecas1 * valorUnitarioPeca1;
        double valorTotalPeca2 = numPecas2 * valorUnitarioPeca2;

        double valorTotalPagar = valorTotalPeca1 + valorTotalPeca2;

        Console.WriteLine($"VALOR A PAGAR: R$ {valorTotalPagar.ToString("F2", culture)}");
    }
}