using System;

public class ConversaoTipo
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um número inteiro:");
        string entrada = Console.ReadLine();

        // Bug: Tentativa de converter uma string não numérica para int
        int numero = Convert.ToInt32(entrada); 

        Console.WriteLine($"Você digitou: {numero}");
    }
}

