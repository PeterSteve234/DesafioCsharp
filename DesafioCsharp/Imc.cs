using System;

class Imc
{
    static void Main()
    {
        Console.Write("Peso (kg): ");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.Write("Altura (m): ");
        double altura = Convert.ToDouble(Console.ReadLine());

        double imc = peso / (altura * altura);
        Console.WriteLine($"IMC: {imc:F2}");

        if (imc < 18.5)
            Console.WriteLine("Abaixo do peso");
        else if (imc < 25)
            Console.WriteLine("Peso normal");
        else if (imc < 30)
            Console.WriteLine("Sobrepeso");
        else
            Console.WriteLine("Obesidade");
    }
}
﻿
