using System;
using System.Diagnostics.Metrics;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a operação desejada: ");
            Console.WriteLine("Soma");
            Console.WriteLine("Subtração");
            Console.WriteLine("Multiplicação");
            Console.WriteLine("Divisão");
            Console.WriteLine("Sair");

            string operacao = Console.ReadLine();
            Console.WriteLine("Digite o Primeiro Valor:");

            string valorInformado = Console.ReadLine();
            int primeiroValor = Convert.ToInt32(valorInformado);

            Console.WriteLine("Digite o Segundo Valor:");
            valorInformado = Console.ReadLine();
            int segundoValor = Convert.ToInt32(valorInformado);
            int resultado = 0;

            switch (operacao)
            {
                case "Soma":
                    resultado = primeiroValor + segundoValor;
                    break;

                case "Subtração":
                    resultado = primeiroValor - segundoValor;
                    break;

                case "Multiplicação":
                    resultado = primeiroValor * segundoValor;
                    break;

                case "Divisão":
                    resultado = primeiroValor / segundoValor;
                    break;

                default:
                    Console.WriteLine("Opção Invalida");
                    break;
            }

            Console.WriteLine($"Resultado: {resultado}");

        }
    }
}
