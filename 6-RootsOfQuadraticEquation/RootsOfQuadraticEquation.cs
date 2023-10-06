public class RootsOfQuadraticEquation
{
    static void Main (string[] args)
    {
        //Ler os valores dos três coeficientes "a", "b" e "c" de uma equação do segundo grau ( +  +  = 0)
        //Em seguida, mostrar os valores das raízes da equação, conforme exemplos, usando a fórmula de Baskara(veja
        //abaixo).Se a equação não possuir raízes(o valor de "a" não pode ser zero, e o valor de "delta" não pode ser
        //negativo), mostrar uma mensagem "Impossivel calcular".

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        var rootsOfQuadraticEquation = new RootsOfQuadraticEquation();
        
        int delta = rootsOfQuadraticEquation.CalculateDelta(a, b, c);
        double x1 = (- b + Math.Sqrt(delta)) / (2 * a);
        double x2 = (- c - Math.Sqrt(delta)) / (2 * b);

    }
    public int CalculateDelta(int a, int b, int c)
    {
        return (b * b) - (4 * a * c);
    }
    public string CalculateRootsOfQuadraticEquation(int a, int b, int c, int delta, double x1, double x2)
    {
        if (a == 0)
        {
            return "The value a can't be zero";

        }
        if (delta < 0)
        {
            return "The value of delta can't be negative";
        }
        else
        {
            return
        }
    }

}