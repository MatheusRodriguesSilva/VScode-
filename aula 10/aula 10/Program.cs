using System;
using PraticaAula10.src;

namespace PraticaAula10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULADORA");

            Calc objeto = new Calc();

            Console.WriteLine($"soma 1 + 2 = {objeto.Somar(1, 2)}");
            Console.WriteLine($"subtração 1 - 2 = {objeto.Subtrair(1, 2)}");
            Console.WriteLine($"multiplicação 1 X 2 = {objeto.Multiplicar(1, 2)}");
            Console.WriteLine($"divisão: 1 / 2 = {objeto.Dividir(1, 2)}");
        }
    }
}