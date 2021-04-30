using System;

namespace Desafio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bom dia! Informe sua idade para encaixarmos você na sua categoria na natação:");
            var idade = int.Parse (Console.ReadLine());

            if (idade>=5 && idade<=7)
            {
                Console.WriteLine("\nVocê tem " + idade + " anos, que te encaixa na categoria Infantil A");
                Console.WriteLine("\n");
            }

            if (idade>=8 && idade<=10)
            {
                Console.WriteLine("\nVocê tem " + idade + " anos, que te encaixa na categoria Infantil B");
                 Console.WriteLine("\n");
            }

            if (idade>=11 && idade<=13)
            {
                Console.WriteLine("\nVocê tem " + idade + " anos, que te encaixa na categoria Juvenil A");
                Console.WriteLine("\n");
            }

            if (idade>=14 && idade<=17)
            {
                Console.WriteLine("\nVocê tem " + idade + " anos, que te encaixa na categoria Juvenil B");
                Console.WriteLine("\n");
            }

            if (idade>=18)
            {
                Console.WriteLine("\nVocê tem " + idade + " anos, que te encaixa na categoria Sênior");
                Console.WriteLine("\n");
            }
        }
    }
}
