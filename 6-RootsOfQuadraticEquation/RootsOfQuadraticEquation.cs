public class RootsOfQuadraticEquation
{
    double x1;
    double x2;

    static void Main (string[] args)
    {
        //Ler os valores dos três coeficientes "a", "b" e "c" de uma equação do segundo grau ( +  +  = 0)
        //Em seguida, mostrar os valores das raízes da equação, usando a fórmula de Baskara.
        //Se a equação não possuir raízes(o valor de "a" não pode ser zero, e o valor de "delta" não pode ser
        //negativo), mostrar uma mensagem "Impossivel calcular".

        Console.WriteLine("Enter with 'a' value:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter with 'b' value:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter with 'c' value:");
        int c = int.Parse(Console.ReadLine());

        var rootsOfQuadraticEquation = new RootsOfQuadraticEquation();
        int delta = rootsOfQuadraticEquation.CalculateDelta(a, b, c);
        string roots = rootsOfQuadraticEquation.CalculateRootsOfQuadraticEquation(a, b, c, delta);

        Console.WriteLine(roots);
    }

    public int CalculateDelta(int a, int b, int c)
    {
        return (b * b) - (4 * a * c);
    }

    public string CalculateRootsOfQuadraticEquation(int a, int b, int c, int delta)
    {
        if (a == 0)
        {
            return "The value of 'a' can't be zero";

        }
        if (delta < 0)
        {
            return "The value of delta can't be negative";
        }
      
        x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        x2 = (-b - Math.Sqrt(delta)) / (2 * b);

        return $"The roots of equation is x1: {x1} and x2: {x2}"; 
    }
}