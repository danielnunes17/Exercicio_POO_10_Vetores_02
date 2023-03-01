/*Fazer um programa para ler um número inteiro N e os dados (nome e preço) de N Produtos. Armazene os N produtos em um vetor.
 Em seguida, mostrar o preço médio dos produtos.
Input:                                              Output: AVERAGE PRICE = 700.00 
3
TV
900.00
Fryer
400.00
Stove
800.00 */

using Exercicio_POO_10_Vetores_02;
using System.Globalization;

Console.Write("Enter the quantity of items: ");
int n = int.Parse(Console.ReadLine());
Product[] vect = new Product[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Enter the name: ");
    string name = Console.ReadLine();
    Console.Write("Enter the price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    vect[i] = new Product(name, price);
}

double sum = 0.0;
for (int i = 0; i < n; i++)
{
    sum += vect[i].Price;
}

Console.WriteLine();
double avg = sum / n;
Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));
