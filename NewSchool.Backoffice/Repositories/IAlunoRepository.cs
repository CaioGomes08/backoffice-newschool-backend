using NewSchool.Backoffice.Entities;
using NewSchool.Backoffice.Queries;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewSchool.Backoffice.Repositories
{
    public interface IAlunoRepository
    {
        Task<IEnumerable<AlunoQueryResult>> ListarAsync();

        Task<AlunoQueryResult> ObterAsync(int id);

        Task SalvarAsync(Aluno aluno);

        Task AtualizarAsync(Aluno aluno);

        Task DeletarAsync(int id);
    }
}
