using Flunt.Notifications;
using NewSchool.Backoffice.Commands.Contracts.Aluno;
using NewSchool.Backoffice.Infra.Comum;

namespace NewSchool.Backoffice.Commands.Input.Aluno
{
    public class ApagarAlunoCommand : Notifiable<Notification>, ICommandPadrao
    {
        public int Id { get; set; }

        public bool EhValido()
        {
            AddNotifications(new ApagarAlunoCommandContract(this));
            return IsValid;
        }
    }
}
