using System;

namespace PraticaAula8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GATOS");
            Gato garfild = new Gato("Garfilf", "Laranja", 8);
            Gato tom = new Gato("Thomas", "cinza", 5);
            Gato frajola = new Gato();

            Console.WriteLine($"gato 1 é o {garfild.Nome} de cor {garfild.Cor} e tamanho {garfild.Tamanho}");
            Console.WriteLine($"gato 2 é o {tom.Nome} de cor {tom.Cor} e tamanho {tom.Tamanho}");
            Console.WriteLine($"gato 3 é o {frajola.Nome} de cor {frajola.Cor} e tamanho {frajola.Tamanho}");

            garfild.comer("ração");
            tom.dormir();
            string retorno = frajola.ronronar();
            Console.WriteLine(retorno);
        }
    }

    internal class Gato
    {
        private string v1;
        private string v2;
        private int v3;

        public Gato(string v1, string v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }
    }
}