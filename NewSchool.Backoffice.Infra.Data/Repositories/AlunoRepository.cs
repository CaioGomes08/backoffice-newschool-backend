using Dapper;
using NewSchool.Backoffice.Entities;
using NewSchool.Backoffice.Infra.Data.Context;
using NewSchool.Backoffice.Infra.Data.Queries;
using NewSchool.Backoffice.Queries;
using NewSchool.Backoffice.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewSchool.Backoffice.Infra.Data.Repositories
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly DataContext context;
        private readonly DynamicParameters param;

        public AlunoRepository(DataContext context)
        {
            this.context = context;
            this.param = new DynamicParameters();
        }

        public async Task<IEnumerable<AlunoQueryResult>> ListarAsync() =>
            await context.Connection.QueryAsync<AlunoQueryResult>(AlunoQueries.LISTAR);

        public async Task<AlunoQueryResult> ObterAsync(int id) =>
            await context.Connection.QueryFirstOrDefaultAsync<AlunoQueryResult>(AlunoQueries.OBTER, new { id });


        public async Task SalvarAsync(Aluno aluno)
        {
            param.Add("@Nome", aluno.Nome);
            param.Add("@Sobrenome", aluno.Sobrenome);
            param.Add("@CPF", aluno.Cpf);
            param.Add("@Telefone", aluno.Telefone);

            await context.Connection.ExecuteScalarAsync(AlunoQueries.SALVAR, param);
        }

        public async Task AtualizarAsync(Aluno aluno)
        {
            param.Add("@Id", aluno.Id);
            param.Add("@Nome", aluno.Nome);
            param.Add("@Sobrenome", aluno.Sobrenome);
            param.Add("@CPF", aluno.Cpf);
            param.Add("@Telefone", aluno.Telefone);

            await context.Connection.ExecuteScalarAsync(AlunoQueries.ATUALIZAR, param);
        }

        public async Task DeletarAsync(int id) =>
            await context.Connection.ExecuteAsync(AlunoQueries.DELETAR, new { id });
    }
}
