using System;
using System.Collections.Generic;

namespace PraticaAula11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista!");

            List<string> lista = new List<string>();

            lista.Add("Matheus");
            lista.Add("Murilo");
            lista.Add("Lucas");
            lista.Add("Guilherme");

            foreach (string item in lista)
            {
                Console.WriteLine(item);
            }

        }
    }
}