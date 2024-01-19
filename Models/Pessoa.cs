using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Faculdade.Models
{


    public class Pessoa
    {
        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public int Cpf { get; set; }
    }
}