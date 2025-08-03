using System;

public class ContadorInfinito
{
    public static void Main(string[] args)
    {
        int i = 0;
        while (i < 10) // Bug: Condição de loop incorreta, causando loop infinito
        {
            Console.WriteLine($"Contador: {i}");
        }
        Console.WriteLine("Contagem finalizada.");
    }
}

