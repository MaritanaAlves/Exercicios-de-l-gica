using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa que leia o número inteiro positivo e calcule o seu dobro, o seu triplo, o seu quadrado, o seu cubo e a sua raiz quadrada.
            int n = int.Parse(Console.ReadLine());

            int dobro = 2 * n;
            int triplo = 3 * n;
            int quadrado = (int)(Math.Pow(n, 2));
            int cubo = (int)(Math.Pow(n, 3));
            double raiz = (double)(Math.Sqrt(n));

            Console.WriteLine("O dobro do número é: " + dobro + ", o triplo do número é: " + triplo + ", o quadrado é: " + quadrado + ", o cubo é: " + cubo + ", a raiz quadrada é: " + raiz);

        }
    }
}
