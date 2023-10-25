using System.Security.AccessControl;
using Fundamentos.Models;

Pessoa p = new Pessoa();

p.Nome =  "Butta";
p.Idade = 26;
p.Apresentar();

DateTime dataatual = DateTime.Now;
Console.WriteLine(dataatual.AddDays(5));

// int a = Convert.ToInt32("5") ; // converter pra outro tipo
int a = int.Parse("5");
Console.WriteLine(a);

/*
int estoque = 10;
int compra = 8;
bool possivelVenda = compra > 0 && estoque >= compra;
Console.WriteLine($"Quantidade em estoque: {estoque}");
Console.WriteLine($"Quantidade compra: {compra}");
Console.WriteLine($"É possivel realizar a venda: {possivelVenda}");
if(compra == 0)
{
    Console.WriteLine("Venda inválida");
}
else if(possivelVenda)
{
    Console.WriteLine("Venda Realizada");
}
else
{
    Console.WriteLine("venda não realizada");
}
*/

Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

/*
switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;

    default:
        Console.WriteLine("não é uma vogal");
        break;
}
*/