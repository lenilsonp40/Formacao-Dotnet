﻿using projeto01.Models;
using System.Globalization;


// parei validaçoes get e set


Pessoa p1 = new Pessoa();
p1.Nome = "Lenilson";
p1.Sobrenome = "Soares";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.ListarAlunos();



/*
Pessoa p1 = new Pessoa();
p1.Nome = "Lenilson";
p1.Sobrenome = "Soares";
p1.Idade = 32;
p1.Apresentar();
*/






/*
string[] linhas = file.ReadAllLines("Arquivos/arquivosLeitura.txt");

foreach(string linha in linhas)
{
    Console.WriteLine(linha);
}






*/