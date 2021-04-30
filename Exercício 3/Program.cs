using System;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bom dia! Por favor, informe o seu salário para checarmos se você receberá o aumento:");
            Console.WriteLine("R$:");
            var salario = int.Parse (Console.ReadLine());
            Console.WriteLine("\nSeu salário é de R$" + salario);

            if (salario>500)
            {
                Console.WriteLine("\nDe acordo com a decisão da empresa, você não está apto a receber o aumento.");
                Console.WriteLine("\n");
            }
            else
            {
                int salarioNovo = ((salario * 30 / 100) + salario);
                Console.WriteLine("\nDe acordo com a decisão da empresa, você está apto a receber o aumento! Seu novo salário é de R$" + salarioNovo);
                Console.WriteLine("\n");
            }
        }
    }
}
