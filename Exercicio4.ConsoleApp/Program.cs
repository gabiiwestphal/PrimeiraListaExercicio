using System;

namespace Exercicio4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius, fahrenheit;

            Console.Write("Digite a temperatura em celsius: ");
            celsius = double.Parse(Console.ReadLine());

            fahrenheit = celsius * 1.8 + 32;

            Console.WriteLine("fahrenheit: {0}", Math.Round(fahrenheit, 1));
        }
    }
}
