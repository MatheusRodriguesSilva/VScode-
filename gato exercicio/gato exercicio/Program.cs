using PraticaAula8.src;
using System;

namespace PraticaAula8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GATOS");
            var garfild = new Gato("Garfilf", "Laranja", 8);
            var tom = new Gato("Thomas", "cinza", 5);
            var frajola = new Gato();

            Console.WriteLine($"gato 1 é o {garfild.Nome} de cor {garfild.Cor} e tamanho {garfild.Tamanho}");
            Console.WriteLine($"gato 2 é o {tom.Nome} de cor {tom.Cor} e tamanho {tom.Tamanho}");
            Console.WriteLine($"gato 3 é o {frajola.Nome} de cor {frajola.Cor} e tamanho {frajola.Tamanho}");

            garfild.comer("ração");
            tom.dormir();
            string retorno = frajola.ronronar();
            Console.WriteLine(retorno);
        }

        private class Gato
        {
            public Gato()
            {
            }
        }
    }
}