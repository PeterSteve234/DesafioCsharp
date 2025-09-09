using System;

class Calculadora
{
    static void Main()
    {
        // escolha do usuário
        Console.WriteLine("=== Calculadora Completa ===");
        Console.WriteLine("Operações disponíveis:");
        Console.WriteLine("1 - Adição (+)");
        Console.WriteLine("2 - Subtração (-)");
        Console.WriteLine("3 - Multiplicação (*)");
        Console.WriteLine("4 - Divisão (/)");
        Console.WriteLine("0 - Sair");

        while (true)
        {
            Console.Write("\nEscolha a operação (0 para sair): ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 0)
            {
                Console.WriteLine("Encerrando a calculadora...");
                break;
            }

            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double resultado = 0;

            switch (opcao)
            {
                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine($"Resultado: {num1} + {num2} = {resultado}");
                    break;
                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine($"Resultado: {num1} - {num2} = {resultado}");
                    break;
                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine($"Resultado: {num1} * {num2} = {resultado}");
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine($"Resultado: {num1} / {num2} = {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Erro: divisão por zero não é permitida!");
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida! Escolha entre 0 e 4.");
                    break;
            }
        }
    }
}
