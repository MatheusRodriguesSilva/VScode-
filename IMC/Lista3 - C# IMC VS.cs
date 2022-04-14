using System;

namespace IMC_Lista_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float peso, altura, imc;
            Console.WriteLine("escreva seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("escreva sua idade: ");
            string idade = Console.ReadLine();

            Console.WriteLine("escreva seu peso: ");
            peso = float.Parse(Console.ReadLine());
            Console.WriteLine("escreva sua altura: ");
            altura = float.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                Console.WriteLine(nome + "seu imc é " + imc + " você esta abaixo do peso");
            }
            else if (imc < 25)
            {
                Console.WriteLine(nome + "seu imc é " + imc + " você esta com peso ideal");
            }
            else if (imc < 30)
            {
                Console.WriteLine(nome + "seu imc é " + imc + " você esta acima do peso");
            }
            else
            {
                Console.WriteLine(nome + "seu imc é " + imc + "e você esta obeso");
            }

        }
    }
}