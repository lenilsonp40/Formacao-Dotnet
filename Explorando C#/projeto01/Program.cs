using projeto01.Models;
using System.Globalization;

// tupla
(int Id, string Nome, string Sobrenome, decimal Altura) dados = (1, "Lenilson", "Soares", 1.71m);

Console.WriteLine($"Id: {dados.Id}");
Console.WriteLine($"Nome: {dados.Nome}");
Console.WriteLine($"Sobrenome: {dados.Sobrenome}");
Console.WriteLine($"Altura: {dados.Altura}");




// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);

// foreach(int item in fila)
// {
//     Console.WriteLine(item);
// }

// int idade = 20;
// int altura = 30;

// Console.WriteLine("Ola mundo " + idade + altura);


// parei validaçoes get e set


// Pessoa p1 = new Pessoa();
// p1.Nome = "Lenilson";
// p1.Sobrenome = "Soares";

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.ListarAlunos();



/*
Pessoa p1 = new Pessoa();
p1.Nome = "Lenilson";
p1.Sobrenome = "Soares";
p1.Idade = 32;
p1.Apresentar();
*/





// try {

// string[] linhas = File.ReadAllLines("Arquivos/arquivos_Leitura.txt");

// foreach(string linha in linhas)
// {
//     Console.WriteLine(linha);
// }

// } catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }








