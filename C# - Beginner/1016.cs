using System;

class Program
{
    static void Main()
    {
        int distancia = int.Parse(Console.ReadLine());

        int diferencaVelocidade = 30;

        int tempo = (distancia * 60) / diferencaVelocidade;

        Console.WriteLine($"{tempo} minutos");
    }
}