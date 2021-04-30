using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nBom dia, por favor, informe o seu ano de nascimento:");
            var anoDeNascimento = int.Parse(Console.ReadLine());
            var anoAtual = System.DateTime.Now.Year;

            int idadePessoa = (anoAtual - anoDeNascimento);
            int idadeEmSemanas = (idadePessoa * 12 * 7);
            Console.WriteLine("\nEntão significa que você tem (provavelmente) " + idadePessoa + " anos. E se você por algum acaso quiser saber essa informação em semanas, aqui está o resultado: " + idadeEmSemanas + " semanas");

            Console.WriteLine("\nNão faço idea de onde você utilizaria a informação em semanas, mas que legal!");
            Console.WriteLine("\n");
        }
    }
}
