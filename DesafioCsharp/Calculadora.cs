using System;

class Imc

{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculadora de IMC");

        Console.Write("Digite seu peso (kg): ");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite sua altura (m): ");
        double altura = Convert.ToDouble(Console.ReadLine());

        double imc = CalcularIMC(peso, altura);

        Console.WriteLine($"Seu IMC é: {imc:F2}");
        ClassificarIMC(imc);
    }

    static double CalcularIMC(double peso, double altura)
    {
        if (altura == 0)
        {
            Console.WriteLine("Erro: altura não pode ser zero.");
            return 0;
        }
        return peso / (altura * altura);
    }

    static void ClassificarIMC(double imc)
    {
        if (imc < 18.5)
            Console.WriteLine("Classificação: Abaixo do peso");
        else if (imc < 25)
            Console.WriteLine("Classificação: Peso normal");
        else if (imc < 30)
            Console.WriteLine("Classificação: Sobrepeso");
        else if (imc < 35)
            Console.WriteLine("Classificação: Obesidade grau I");
        else if (imc < 40)
            Console.WriteLine("Classificação: Obesidade grau II");
        else
            Console.WriteLine("Classificação: Obesidade grau III (mórbida)");
    }
}
