using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //* Escreva um programa que leia o valor do lado de um quadrado e calcule a sua área e o seu perímetro.*//
            Console.Write("Digite o lado do quadrado: ");
            double lado = double.Parse(Console.ReadLine());

            double area = lado * lado;
            double perimetro = 4 * lado;

            Console.Write("A área do quadrado é: " + area + "m², o perímetro é: " + perimetro + "m.");
        }
    }
}
