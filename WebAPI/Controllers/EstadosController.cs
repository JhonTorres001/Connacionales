using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplicacion.Estados;
using Dominio;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Persistencia;

namespace WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EstadosController : ControllerBase
    { 
    
        private readonly IMediator _mediator;
        public EstadosController(IMediator mediator){

            _mediator = mediator;
        }       


        [HttpGet]
        public async Task<ActionResult<List<Estado>>> Get(){
            return await _mediator.Send(new Consulta.ListaEstado());    
        }
    }
}