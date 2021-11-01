namespace NewSchool.Backoffice.Infra.Data.Queries
{
    public class AlunoQueries
    {
        public const string LISTAR =
            @"SELECT  Id,
                    Nome, 
                    Sobrenome, 
                    CPF, 
                    Telefone 
            FROM  Aluno;";

        public const string OBTER = "";
        public const string SALVAR = @"INSERT INTO Aluno (Nome, Sobrenome, CPF, Telefone)
                                     VALUES(@Nome, @Sobrenome, @CPF, @Telefone)";
        public const string ATUALIZAR = "";
        public const string DELETAR = "";
    }
}
