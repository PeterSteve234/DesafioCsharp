using System;

class Calculadora
{
    static void Main()
    {
        Console.WriteLine("Calculadora de IMC");

        
        Console.Write("Digite seu peso em kg: ");
        double peso = Convert.ToDouble(Console.ReadLine());

        
        Console.Write("Digite sua altura em metros (ex: 1.75): ");
        double altura = Convert.ToDouble(Console.ReadLine());

        
        double imc = peso / (altura * altura);

        
        Console.WriteLine($"Seu IMC é: {imc:F2}");

        // Classificação
        if (imc < 18.5)
        {
            Console.WriteLine("Abaixo do peso");
        }
        else if (imc >= 18.5 && imc < 25)
        {
            Console.WriteLine("Peso normal");
        }
        else if (imc >= 25 && imc < 30)
        {
            Console.WriteLine("Sobrepeso");
        }
        else
        {
            Console.WriteLine("Obesidade");
        }
    }
}
