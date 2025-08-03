using System;
using System.Collections.Generic;

public class VazamentoMemoria
{
    private static List<byte[]> data = new List<byte[]>();

    public static void Main(string[] args)
    {
        Console.WriteLine("Pressione Enter para alocar memória (pode causar vazamento).");
        Console.ReadLine();

        // Bug: Alocação contínua de memória sem liberação, pode levar a OutOfMemoryException
        while (true)
        {
            data.Add(new byte[1024 * 1024]); // Aloca 1MB
            Console.WriteLine($"Memória alocada: {data.Count} MB");
            Thread.Sleep(100); // Pequena pausa
        }
    }
}

