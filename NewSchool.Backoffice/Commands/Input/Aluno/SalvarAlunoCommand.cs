using Flunt.Notifications;
using NewSchool.Backoffice.Commands.Contracts.Aluno;
using NewSchool.Backoffice.Infra.Comum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSchool.Backoffice.Commands.Input
{
    public class SalvarAlunoCommand : Notifiable<Notification>, ICommandPadrao
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }

        public bool EhValido()
        {
            AddNotifications(new SalvarAlunoCommandContract(this));
            return IsValid;
        }
    }
}
