using System;

class Program
{
    static void Main()
    {
        int tempo = int.Parse(Console.ReadLine());
        int velocidade = int.Parse(Console.ReadLine());

        double distancia = tempo * velocidade;

        double litros = distancia / 12.0;

        Console.WriteLine($"{litros:F3}");
    }
}