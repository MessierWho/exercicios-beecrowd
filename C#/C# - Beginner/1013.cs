using System;

class Program
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split();
        int a = int.Parse(inputs[0]);
        int b = int.Parse(inputs[1]);
        int c = int.Parse(inputs[2]);

        int maiorAB = (a + b + Math.Abs(a - b)) / 2;
        int maior = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;

        Console.WriteLine($"{maior} eh o maior");
    }
}