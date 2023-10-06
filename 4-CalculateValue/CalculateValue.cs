using System.Globalization;
using _4_CalculateValue;

public class CalculateValue
{
    static void Main(string[] args)
    {
        //Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
        //código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Calcule e mostre o valor a ser pago.

        Console.Write("Enter product 1 code: ");
        int cod1 = int.Parse(Console.ReadLine());
        Console.Write("Enter product 1 amount: ");
        int qtd1 = int.Parse(Console.ReadLine());
        Console.Write("Enter product 1 value: ");
        double value1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Enter product 2 code: ");
        int cod2 = int.Parse(Console.ReadLine());
        Console.Write("Enter product 2 amount: ");
        int qtd2 = int.Parse(Console.ReadLine());
        Console.Write("Enter product 2 value: ");
        double value2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        var calculateValue = new CalculateValue();
        
        Product product1 = new Product(cod1, qtd1, value1);
        product1.TotalValue(qtd1, value1);
        Product product2 = new Product(cod2, qtd2, value2);
        product2.TotalValue(qtd2, value2);

        double valueToPay = calculateValue.CalculateValueToPay(product1, product2);

        Console.WriteLine("Value to pay: " + valueToPay);
    }

    public double CalculateValueToPay(Product product1, Product product2)
    {
        double valueToPay = product1.TotalValue(product1.Amount, product1.Value);
        double valueToPay2 = product2.TotalValue(product2.Amount,product2.Value);
        return valueToPay + valueToPay2; 
    }
       
}

