using System;

namespace Exercicio3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade, diasDeVida;

            Console.Write("informe seu nome: ");
            nome = Console.ReadLine();

            Console.Write("informe sua idade: ");
            idade = int.Parse(Console.ReadLine());

            diasDeVida = idade * 365;

            Console.WriteLine(nome + ", você já viveu " + diasDeVida + " dias");

            Console.ReadLine();
        }
    }
}
