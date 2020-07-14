using System.Collections.Generic;
using System.Threading.Tasks;
using Dominio;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class SolicitanteController : ControllerBase
    { 
         
        private readonly IMediator _mediator;
        public SolicitanteController(IMediator mediator){
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<Solicitante>>> Get(){
            return await _mediator.Send(new Aplicacion.Solicitantes.Consulta.ListaSolicitante());    
        }
    }
}