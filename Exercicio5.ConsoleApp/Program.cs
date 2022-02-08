using System;

namespace Exercicio5.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorAumento = 0.15;
            double impostos = 0.8;

            double salarioAtual, salarioComAumento, salarioFinal;

            Console.Write("Digite o seu salário atual: ");
            salarioAtual = double.Parse(Console.ReadLine());

            salarioComAumento = salarioAtual + salarioAtual * valorAumento;

            salarioFinal = salarioComAumento - salarioComAumento * impostos;

            Console.WriteLine("\nO salário com aumento é: " + salarioComAumento);
            Console.WriteLine("O salário final é: " + salarioFinal);
        }
    }
}
