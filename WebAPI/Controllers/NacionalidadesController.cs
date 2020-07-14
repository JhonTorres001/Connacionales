using MediatR;
using Microsoft.AspNetCore.Mvc;

using Aplicacion.Nacionalidades;
using System.Threading.Tasks;
using System.Collections.Generic;
using Dominio;

namespace WebAPI.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class NacionalidadesController : ControllerBase
    {
        
        private readonly IMediator _mediator;
        public NacionalidadesController(IMediator mediator){
            _mediator = mediator;
        }       

        [HttpGet]
        public async Task<ActionResult<List<Nacionalidad>>> Get(){
            return await _mediator.Send(new Consulta.ListaNacionalidades());    
        }
    }
}