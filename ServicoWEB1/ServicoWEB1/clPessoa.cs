using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicoWEB1
{
    public class clPessoa
    {
        public string cpf { get; set; }
        public string nome { get; set; }
        public DateTime dt_nascimento { get; set; }

        public clPessoa() { }
        public clPessoa(string cpf, string nome, DateTime dt_nascimento)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.dt_nascimento = dt_nascimento;
        }

        public clPessoa(clPessoa clPessoa):this(clPessoa.cpf, clPessoa.nome, clPessoa.dt_nascimento)
        {
            
        }
    }
}