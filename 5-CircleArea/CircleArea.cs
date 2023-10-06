using System.Globalization;

public class CircleArea
{
    static void Main(string[] args)
    {
        //Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo
        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        const double pi = 3.14159;

        var circleArea = new CircleArea();

        double area = circleArea.CalculateCircleArea(raio, pi);

        Console.WriteLine("The circle area: " + area, CultureInfo.InvariantCulture);
    }

    public double CalculateCircleArea(double raio, double pi)
    {
        return pi * (raio * raio);
    }
}

