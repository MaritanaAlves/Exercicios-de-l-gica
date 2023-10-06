using System.Globalization;

public class AreaPerimeter
{
    static void Main(string[] args)
    {
        //* Escreva um programa que leia o valor do lado de um quadrado e calcule a sua área e o seu perímetro.*//
        double side = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        var areaPerimeter = new AreaPerimeter();

        double area = areaPerimeter.CalculateArea(side);
        double perimeter = areaPerimeter.CalculatePerimeter(side);

        Console.Write("The area of square: " + area + "m², perimeter: " + perimeter + "m.");   
    }

    public double CalculateArea(double side)
    {
        return side * side;
    }

    public double CalculatePerimeter(double side)
    {
        return 4 * side;
    }
}
