using Flunt.Notifications;
using NewSchool.Backoffice.Commands.Contracts.Aluno;
using NewSchool.Backoffice.Infra.Comum;

namespace NewSchool.Backoffice.Commands.Input.Aluno
{
    public class AtualizarAlunoCommand : Notifiable<Notification>, ICommandPadrao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }

        public bool EhValido()
        {
            AddNotifications(new AtualizarAlunoCommandContract(this));
            return IsValid;
        }
    }
}
