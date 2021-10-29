using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pedra_papel_tesoura_lagarto_Spock.Core;
using Pedra_papel_tesoura_lagarto_Spock.Core.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Pedra_papel_tesoura_lagarto_Spock.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JogoController : BaseController
    {
       
        [HttpPost("jogo-contra-computador")]
        public async Task<IActionResult> GetWinner([FromBody][Required] Jogo jogo, [FromServices] Service service)
        {
            var response = await service.ContraComputador(jogo);

            return response.Item2 == HttpStatusCode.BadRequest ? BadRequestResponse(response.Item1) : OkResponse(response.Item1);

        }

        [HttpPost("jogo-contra-jogaodr")]
        public async Task<IActionResult> GetPatient([FromBody][Required] List<Jogo> escolhas, [FromServices] Service service)
        {
            if(escolhas.Count > 2) { return BadRequestResponse("Proxima atualização sera implementado a possibilidade de outros jogadores"); }

            var response = await service.JogadorXJogador(escolhas);

            return response.Item2 == HttpStatusCode.BadRequest ? BadRequestResponse(response.Item1) : OkResponse(response.Item1);

        }
    }
}
