using System;

namespace Exercicio2.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int paoFrances, broas;
            double totalVendido, poupanca;

            Console.WriteLine("Padaria Hotpão");
            Console.WriteLine("--------------");

            Console.WriteLine("insira a quantidade de pão francês vendidos hoje: ");
            paoFrances = int.Parse(Console.ReadLine());

            Console.WriteLine("insira a quantidade de broas vendidas hoje: ");
            broas = int.Parse(Console.ReadLine());

            totalVendido = paoFrances * 0.12 + broas * 1.50;
            poupanca = totalVendido * 0.1;

            Console.WriteLine("total: " + totalVendido);
            Console.WriteLine("valor direcionado a poupança: " + Math.Round(poupanca, 2));
        }
    }
}
