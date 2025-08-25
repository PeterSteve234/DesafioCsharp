using System;

class Iterando
{
    static void Main(string[] args)
    {
        int soma = 0;

        for (int i = 1; i <= 10; i++)
        {
            soma += i;
        }

        Console.WriteLine("A soma de 1 até 10 é: " + soma);
    }
}
