using Flunt.Validations;
using NewSchool.Backoffice.Commands.Input;

namespace NewSchool.Backoffice.Commands.Contracts.Aluno
{
    public class SalvarAlunoCommandContract : Contract<SalvarAlunoCommand>
    {
        public SalvarAlunoCommandContract(SalvarAlunoCommand command)
        {
            Requires().IsNotNullOrEmpty(command.Nome, "Nome", "Nome é obrigatório!");
            Requires().IsNotNullOrEmpty(command.Sobrenome, "Sobrenome", "Sobrenome é obrigatório!");
            Requires().IsNotNullOrEmpty(command.Cpf, "Cpf", "Cpf é obrigatório!");
            Requires().IsNotNullOrEmpty(command.Telefone, "Telefone", "Cpf é obrigatório!");
        }
    }
}
