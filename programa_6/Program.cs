using System;

public class Fatorial
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um número para calcular o fatorial:");
        int n = Convert.ToInt32(Console.ReadLine());

        long resultado = 1;
        for (int i = 1; i <= n; i++)
        {
            resultado *= i; // Bug: Pode ocorrer overflow para números grandes
        }

        Console.WriteLine($"O fatorial de {n} é: {resultado}");
    }
}

