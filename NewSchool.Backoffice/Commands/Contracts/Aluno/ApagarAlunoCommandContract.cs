using Flunt.Validations;
using NewSchool.Backoffice.Commands.Input.Aluno;

namespace NewSchool.Backoffice.Commands.Contracts.Aluno
{
    public class ApagarAlunoCommandContract : Contract<ApagarAlunoCommand>
    {
        public ApagarAlunoCommandContract(ApagarAlunoCommand command)
        {
            Requires().IsNullOrEmpty(command.Id.ToString(), "Id", "O Campo 'Id' é obrigatório");
            Requires().IsGreaterThan(command.Id, 0, "Id", "O Campo Id é deve ser maior que 0");
        }
    }
}
