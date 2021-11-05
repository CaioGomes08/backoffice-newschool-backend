using NewSchool.Backoffice.Commands.Input;
using NewSchool.Backoffice.Commands.Input.Aluno;
using NewSchool.Backoffice.Commands.Output;
using NewSchool.Backoffice.Entities;
using NewSchool.Backoffice.Infra.Comum;
using NewSchool.Backoffice.Repositories;
using System.Threading.Tasks;

namespace NewSchool.Backoffice.Handlers
{
    public class AlunoHandler : ICommandHandler<SalvarAlunoCommand>,
                                 ICommandHandler<AtualizarAlunoCommand>,
                                 ICommandHandler<ApagarAlunoCommand>
    {
        private readonly IAlunoRepository repository;

        public AlunoHandler(IAlunoRepository repository)
        {
            this.repository = repository;
        }

        public async Task<ICommandResult> HandleAsync(SalvarAlunoCommand command)
        {
            if (!command.EhValido())
                return new BackOfficeCommandResult(false, "Não foi possível salvar Aluno", command.Notifications);

            var salvarAluno = new Aluno(command.Nome,
                                            command.Sobrenome,
                                            command.Cpf,
                                            command.Telefone);

            await repository.SalvarAsync(salvarAluno);
            return new BackOfficeCommandResult(true, "Aluno inserido com sucesso", salvarAluno);
        }

        public async Task<ICommandResult> HandleAsync(AtualizarAlunoCommand command)
        {
            if (!command.EhValido())
                return new BackOfficeCommandResult(false, "Não foi possível atualizar o Aluno", command.Notifications);

            var salvarAluno = new Aluno(command.Id,
                                            command.Nome,
                                            command.Sobrenome,
                                            command.Cpf,
                                            command.Telefone);

            await repository.AtualizarAsync(salvarAluno);
            return new BackOfficeCommandResult(true, "Aluno atualizado com sucesso", command);
        }

        public async Task<ICommandResult> HandleAsync(ApagarAlunoCommand command)
        {
            if (!command.EhValido())
                return new BackOfficeCommandResult(false, "Não foi possivel apagar Aluno", command.Notifications);

            await repository.DeletarAsync(command.Id);
            return new BackOfficeCommandResult(true, "Aluno deletado com sucesso", command);
        }
    }
}
