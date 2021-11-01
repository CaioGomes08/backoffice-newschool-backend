using Microsoft.AspNetCore.Mvc;
using NewSchool.Backoffice.Commands.Input;
using NewSchool.Backoffice.Commands.Input.Aluno;
using NewSchool.Backoffice.Entities;
using NewSchool.Backoffice.Handlers;
using NewSchool.Backoffice.Infra.Comum;
using NewSchool.Backoffice.Repositories;
using System.Threading.Tasks;

namespace backoffice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly AlunoHandler handler;

        private readonly IAlunoRepository repository;

        public AlunoController(AlunoHandler handler, IAlunoRepository repository)
        {
            this.handler = handler;
            this.repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync() =>
            Ok(await repository.ListarAsync());


        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(int id) =>
            Ok(await repository.ObterAsync(id));


        [HttpPost]
        public async Task<ICommandResult> PostAsync([FromBody] SalvarAlunoCommand command)
        {
            return await handler.HandleAsync(command);
        }

        [HttpPut]
        public async Task<ICommandResult> PutAsync([FromBody] AtualizarAlunoCommand command)
        {
            return await handler.HandleAsync(command);
        }

        [HttpDelete("{id}")]
        public async Task<ICommandResult> Delete(int id)
        {
            var command = new ApagarAlunoCommand() { Id = id };
            return await handler.HandleAsync(command);
        }
    }
}
