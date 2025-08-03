using System;

public class ManipulacaoString
{
    public static void Main(string[] args)
    {
        string texto = null; // Bug: Variável de string nula

        // Tentativa de chamar um método em uma string nula
        Console.WriteLine($"Tamanho do texto: {texto.Length}"); 
    }
}

