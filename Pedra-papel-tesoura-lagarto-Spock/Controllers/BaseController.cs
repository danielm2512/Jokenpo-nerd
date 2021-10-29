using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pedra_papel_tesoura_lagarto_Spock.Controllers
{
    [Produces("application/json")]
    [ApiController]
    public class BaseController : Controller
    {
        [NonAction]
        protected IActionResult OkResponse(string resultado)
        {
            return Ok(resultado);
        }

		[NonAction]
		protected IActionResult BadRequestResponse(string error = null)
		{
			return new ObjectResult(error)
			{
				StatusCode = 400
			};
		}
	}
}
