using Flunt.Validations;
using NewSchool.Backoffice.Commands.Input.Aluno;

namespace NewSchool.Backoffice.Commands.Contracts.Aluno
{
    public class AtualizarAlunoCommandContract : Contract<AtualizarAlunoCommand>
    {
        public AtualizarAlunoCommandContract(AtualizarAlunoCommand command)
        {
            Requires().IsNotNullOrEmpty(command.ToString(), "Id", "O campo 'Id' é obrigatório");
            Requires().IsGreaterThan(command.Id, 0, "Id", "Id deve ser maior que 0.");
            Requires().IsNotNullOrEmpty(command.Nome, "Nome", "O campo 'Nome' é obrigatório");
            Requires().IsNotNullOrEmpty(command.Sobrenome, "Sobrenome", "O campo 'Sobrenome' é obrigatório");
            Requires().IsNotNullOrEmpty(command.Cpf, "CPF", "O campo 'CPF' é obrigatório");
            Requires().IsNotNullOrEmpty(command.Telefone, "Telefone", "O campo 'Telefone' é obrigatório");
        }
    }
}
