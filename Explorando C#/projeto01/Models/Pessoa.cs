using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto01.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set;}        
        public string NomeCompleto => $"{Nome} {Sobrenome}";
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");                        
        }
    }

    
}