using DomainLayer.Interfaces.Repository;
using DomainLayer.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ApplicationLayer.Controllers
{
    /// <summary>
    /// Controller respons�vel por gerenciar o cadastro de alunos
    /// </summary>
    [ApiController]
    [Route("api/aluno")]
    public class AlunoController : ControllerBase
    {
        private readonly ILogger<AlunoController> _logger;
        private readonly IAlunoService _alunoService;

        /// <inheritdoc />
        public AlunoController(ILogger<AlunoController> logger, IAlunoService alunoService)
        {
            _logger = logger;
            _alunoService = alunoService;
        }

        /// <summary>
        /// M�todo respons�vel por listar todos os alunos cadastrados
        /// </summary>
        /// <returns>200, 400</returns>
        [HttpGet]
        [SwaggerOperation("Lista os alunos")]
        [SwaggerResponse(200)]
        [SwaggerResponse(400)]
        public ActionResult<IEnumerable<Aluno>> Lista()
        {
            var alunos = _alunoService.Lista();

            return Ok(alunos);
        }

        /// <summary>
        /// M�todo respons�vel por registrar um aluno no sistema
        /// </summary>
        /// <returns>201, 400</returns>
        [HttpPost]
        [SwaggerOperation("Registra aluno")]
        [SwaggerResponse(201)]
        [SwaggerResponse(400)]
        public async Task<ActionResult> RegistraAsync([FromBody] Aluno aluno)
        {
            await _alunoService.Registra(aluno);

            return Created("", "");
        }

        /// <summary>
        /// M�todo respons�vel por buscar aluno pelo nome
        /// </summary>
        /// <returns>200, 400</returns>
        [HttpGet("{nome}")]
        [SwaggerOperation("Busca o(s) aluno(s)")]
        [SwaggerResponse(200)]
        [SwaggerResponse(400)]
        public async Task<ActionResult<IEnumerable<Aluno>>> BuscaAsync([FromRoute] string nome)
        {
            var alunos = await _alunoService.Lista();

            return Ok(alunos);
        }

        /// <summary>
        /// M�todo respons�vel por atualizar um aluno no sistema
        /// </summary>
        /// <returns>204, 400</returns>
        [HttpPatch()]
        [SwaggerOperation("Atualiza aluno")]
        [SwaggerResponse(204)]
        [SwaggerResponse(400)]
        public async Task<ActionResult> AtualizaAsync([FromBody] Aluno aluno)
        {
            await _alunoService.Atualiza(aluno);

            return NoContent();
        }

        /// <summary>
        /// M�todo respons�vel por apaga um aluno no sistema
        /// </summary>
        /// <returns>204, 400</returns>
        [HttpDelete()]
        [SwaggerOperation("Apaga aluno")]
        [SwaggerResponse(204)]
        [SwaggerResponse(400)]
        public async Task<ActionResult> ApagaAsync([FromRoute] Guid id)
        {
            await _alunoService.Apaga(id);

            return NoContent();
        }
    }
}