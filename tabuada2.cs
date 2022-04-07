using System;

namespace Exercicio_3_CS_lista_6_tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("TABUADA");
            Console.WriteLine("insira o numero você quer gerar a tabuada: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int x = 1; x <= 10; x++)
            {
                int resultado = (numero * x);

                Console.WriteLine($"{numero} X {x} = {resultado}");
            }
        }
    }
}