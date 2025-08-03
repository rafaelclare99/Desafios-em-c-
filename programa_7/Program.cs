using System;

public class NumeroPrimo
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite um número para verificar se é primo:");
        int numero = Convert.ToInt32(Console.ReadLine());

        bool ehPrimo = true;
        for (int i = 2; i < numero; i++) // Bug: Lógica incorreta para verificar número primo
        {
            if (numero % i == 0)
            {
                ehPrimo = false;
            }
        }

        if (ehPrimo)
        {
            Console.WriteLine($"{numero} é um número primo.");
        }
        else
        {
            Console.WriteLine($"{numero} não é um número primo.");
        }
    }
}

