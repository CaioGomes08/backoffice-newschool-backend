
using Flunt.Br;
using Flunt.Validations;
using NewSchool.Backoffice.Commands.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSchool.Backoffice.Commands.Contracts.Aluno
{
    public class SalvarAlunoCommandContract : Contract<SalvarAlunoCommand>
    {
        public SalvarAlunoCommandContract(SalvarAlunoCommand command)
        {
            Requires().IsNotNullOrEmpty(command.Nome, "Nome", "Nome é obrigatório!");
            Requires().IsNotNullOrEmpty(command.Sobrenome, "Sobrenome", "Sobrenome é obrigatório!");
            Requires().IsNotNullOrEmpty(command.Cpf, "Cpf", "Cpf é obrigatório!");
        }
    }
}
