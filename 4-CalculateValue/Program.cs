using System.Globalization;


Console.Write("Digite o código da peça 1: ");
int cod1 = int.Parse(Console.ReadLine());
Console.Write("Digite a quantidade de peças: ");
int qtd1 =  int.Parse(Console.ReadLine());
Console.Write("Valor de cada peça: ");
double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Digite o código da peça 2: ");
int cod2 = int.Parse(Console.ReadLine());
Console.Write("Digite a quantidade de peças: ");
int qtd2 = int.Parse(Console.ReadLine());
Console.Write("Valor de cada peça: ");
double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double valorPagar =  (qtd1 * valor1) + (qtd2 * valor2);

Console.WriteLine("Valor a Pagar: " + valorPagar);
