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
        
        public const string ATUALIZAR = @"UPDATE Aluno 
                                          SET Nome = @Nome, 
                                              Sobrenome = @Sobrenome,
                                              CPF = @CPF,
                                              Telefone = @Telefone
                                        WHERE Id = @Id";

        public const string DELETAR = "DELETE FROM Aluno WHERE Id = @id;";
    }
}
