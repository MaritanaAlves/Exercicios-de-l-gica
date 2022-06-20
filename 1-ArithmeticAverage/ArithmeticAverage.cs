public class ArithmeticAverage
{
    static void Main(string[] args)
    {
        //* Escreva um programa que leia três números inteiros e calcule a sua média aritmética. *//
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int n3 = int.Parse(Console.ReadLine());

        var arithmeticAverage = new ArithmeticAverage();

        int media = arithmeticAverage.CalculateArithmeticAverage(n1, n2, n3);

        Console.WriteLine("A média é: " + media);
    }

    public int CalculateArithmeticAverage(int n1, int n2, int n3)
    {
        return (n1 + n2 + n3) / 3;
    }
}
