using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bom dia, quantos anos você tem?");
            var idadePessoa = int.Parse (Console.ReadLine());

            Console.WriteLine("\nLegal! Isso significa que... ");
            
            int idadeEmMeses = (idadePessoa * 12);
            int idadeEmDias = (idadeEmMeses * 30);
            int idadeEmHoras = (idadeEmDias * 24);
            int idadeEmMinutos = (idadeEmHoras * 60);

            Console.WriteLine("\nSua idade, em anos, equivale a " + idadeEmMeses + " meses, " + idadeEmDias + " dias, " + idadeEmHoras + " horas e " + idadeEmMinutos + " minutos.");

            Console.WriteLine("\nIsso é muito tempo!");
            Console.WriteLine("\n");
        }
    }
}
