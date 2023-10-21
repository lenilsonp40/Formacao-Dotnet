using Fundamentos.Models;

Pessoa p = new Pessoa();

p.Nome =  "Butta";
p.Idade = 26;
p.Apresentar();

DateTime dataatual = DateTime.Now;
Console.WriteLine(dataatual.AddDays(5));

