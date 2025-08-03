using System;

public class CalculadoraSimples
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Calculadora Simples");
        Console.WriteLine("Digite o primeiro número:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int resultado = num1 / num2; // Bug: Divisão por zero se num2 for 0

        Console.WriteLine($"O resultado da divisão é: {resultado}");
    }
}

