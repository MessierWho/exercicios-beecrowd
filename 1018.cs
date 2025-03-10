using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        Console.WriteLine(N);

        int[] notas = {100, 50, 20, 10, 5, 2, 1};

        foreach (int nota in notas)
        {
            int quantidadeNotas = N / nota;

            Console.WriteLine($"{quantidadeNotas} nota(s) de R$ {nota},00");
            
            N = N % nota;
        }
    }
}