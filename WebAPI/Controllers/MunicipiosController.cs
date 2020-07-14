using System.Collections.Generic;
using System.Threading.Tasks;
using Dominio;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Aplicacion.Municipios;

namespace WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MunicipiosController : ControllerBase
    {
        private readonly IMediator _mediator;
        public MunicipiosController(IMediator mediator){
            _mediator = mediator;
        }       

        [HttpGet]
        public async Task<ActionResult<List<Municipio>>> Get(){
            return await _mediator.Send(new Consulta.ListaMunicipios());    
        }
    }
}