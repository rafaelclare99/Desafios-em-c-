using System;
using System.Collections.Generic;

public class OrdenacaoIncorreta
{
    public static void Main(string[] args)
    {
        List<int> numeros = new List<int> { 5, 2, 8, 1, 9, 4 };

        // Bug: Lógica de ordenação incorreta (exemplo: bubble sort com erro)
        for (int i = 0; i < numeros.Count; i++)
        {
            for (int j = 0; j < numeros.Count - 1; j++) // Bug: Condição de loop interna incorreta
            {
                if (numeros[j] < numeros[j + 1]) // Bug: Comparação incorreta para ordenação crescente
                {
                    // Trocar elementos
                    int temp = numeros[j];
                    numeros[j] = numeros[j + 1];
                    numeros[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Lista ordenada (incorretamente):");
        foreach (int numero in numeros)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();
    }
}

