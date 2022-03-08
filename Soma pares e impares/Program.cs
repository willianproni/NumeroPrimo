using System;

namespace Soma_pares_e_impares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Soma de pares e impares--\n");

            int n;



            do
            {
                Console.WriteLine("Digite um numero para saber se ele é primo: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 0);

            if (n < 1)
            {
                Console.WriteLine("Digite um número positivo, não existe número primo negativo");
            }
            else
            {
                if (n % 2 == 0 && n / 2 != 1)
                {
                    Console.WriteLine("\nO número digitado NÃO É primo!");
                }
                else if (n % 3 == 0 && n / 3 != 1)
                {
                    Console.WriteLine("\nO número digitado NÃO É primo!");
                }
                else if (n % 5 == 0 && n / 5 != 1)
                {
                    Console.WriteLine("\nO número digitado NÃO É primo!");
                }
                else if (n % 7 == 0 && n / 7 != 1)
                {
                    Console.WriteLine("\nO número digitado NÃO É primo!");
                }
                else
                {
                    Console.WriteLine("\nO número digitado É primo!");
                }
            }
        }
    }
}
