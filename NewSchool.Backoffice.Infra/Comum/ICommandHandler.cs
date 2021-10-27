using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSchool.Backoffice.Infra.Comum
{
    public interface ICommandHandler<T> where T : ICommandPadrao
    {
        Task<ICommandResult> HandleAsync(T command);
    }
}
