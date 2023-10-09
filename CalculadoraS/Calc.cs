using System;

namespace CalculadoraSimples
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Digite o primeiro número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escolha a operação ( +, -, *, / ):");
            char operacao = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();

            double resultado = 0;

            switch (operacao)
            {
                case '+':
                    resultado = numero1 + numero2;
                    break;

                case '-':
                    resultado = numero1 - numero2;
                    break;

                case '*':
                    resultado = numero1 * numero2;
                    break;

                case '/':
                    if (numero2 != 0)
                        resultado = numero1 / numero2;

                    else
                    {
                        Console.WriteLine("Erro");
                        return;
                    }
                    break;
                deafault:
                    Console.WriteLine("Operação inválida");
                    return;
            }

            Console.WriteLine($"Resultado: {numero1} {operacao} {numero2} = {resultado}");
        }
    }
}
