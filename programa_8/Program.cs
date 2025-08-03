using System;
using System.Threading;

public class ContadorCompartilhado
{
    private static int contador = 0;

    public static void Main(string[] args)
    {
        Thread t1 = new Thread(IncrementarContador);
        Thread t2 = new Thread(IncrementarContador);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();

        // Bug: Problema de concorrência - o resultado final pode não ser o esperado
        Console.WriteLine($"Valor final do contador: {contador}"); 
    }

    public static void IncrementarContador()
    {
        for (int i = 0; i < 100000; i++)
        {
            contador++;
        }
    }
}

