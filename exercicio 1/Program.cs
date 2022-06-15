using System;

namespace exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //* Escreva um programa que leia três números inteiros e calcule a sua média aritmética. *//
            int n = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            int media = (n + n2 + n3) / 3;

            Console.WriteLine("A média é: " + media);
        }
    }
}
