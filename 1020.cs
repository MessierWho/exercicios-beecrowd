using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        int anos = N / 365;
        N = N % 365;
        int meses = N / 30;
        int dias = N % 30;

        Console.WriteLine($"{anos} ano(s)");
        Console.WriteLine($"{meses} mes(es)");
        Console.WriteLine($"{dias} dia(s)");
    }
}