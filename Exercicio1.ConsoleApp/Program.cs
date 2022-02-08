using System;

namespace Exercicio1.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double largura, Altura, Area;

            Console.WriteLine("Bem- vindo a imobiliária Imóbilis");

            Console.WriteLine("Insira as medidas do (em metros) terreno: ");

            Console.WriteLine("Largura: ");
            Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Comprimento:  ");
            largura = double.Parse(Console.ReadLine());

            Area = largura * Altura;
            Console.WriteLine("A area do terreno é: " + Area + " metros");
        }
    }
}
