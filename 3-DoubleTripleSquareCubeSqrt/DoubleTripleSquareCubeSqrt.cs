public class DoubleTripleSquareCubeSqrt
{
    static void Main(string[] args)
    {
        //Escreva um programa que leia o número inteiro positivo e calcule o seu dobro, o seu triplo, o seu quadrado, o seu cubo e a sua raiz quadrada.
        int n = int.Parse(Console.ReadLine());

        var doubleTripleSquareCubeSqrt = new DoubleTripleSquareCubeSqrt();

        int @double = doubleTripleSquareCubeSqrt.CalculateDouble(n);
        int triple = doubleTripleSquareCubeSqrt.CalculateTriple(n);
        int square = doubleTripleSquareCubeSqrt.CalculateSquare(n);
        int cube = doubleTripleSquareCubeSqrt.CalculateCube(n);
        double sqrt = doubleTripleSquareCubeSqrt.CalculateSqrt(n);

        Console.WriteLine("Double: " + @double + ", triple: " + triple + ", square: " + square + ", cube: " + cube + ", sqrt: " + sqrt);
    }

    public int CalculateDouble(int n)
    {
        return 2 * n;
    }

    public int CalculateTriple(int n)
    {
        return 3 * n;
    }

    public int CalculateSquare(int n)
    {
        return (int)(Math.Pow(n, 2));
    }

    public int CalculateCube(int n)
    {
        return (int)(Math.Pow(n, 3));
    }

    public double CalculateSqrt(double n)
    {
        return (double)(Math.Sqrt(n));
    }
}