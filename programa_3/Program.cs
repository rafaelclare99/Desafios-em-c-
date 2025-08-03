using System;

public class AcessoArray
{
    public static void Main(string[] args)
    {
        int[] numeros = { 10, 20, 30, 40, 50 };

        // Bug: Tentativa de acessar um índice fora dos limites do array
        Console.WriteLine($"O sexto número é: {numeros[5]}"); 
    }
}

