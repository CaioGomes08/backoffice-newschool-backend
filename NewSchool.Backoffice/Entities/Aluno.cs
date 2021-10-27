using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSchool.Backoffice.Entities
{
    public class Aluno
    {
        public Aluno() { }

        public Aluno(string nome, string sobrenome, string cpf, string telefone)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Cpf = cpf;
            Telefone = telefone;
        }

        public Aluno(int id, string nome, string sobrenome, string cpf, string telefone)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            Cpf = cpf;
            Telefone = telefone;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
    }
}
