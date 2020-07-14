using System.Collections.Generic;
using System.Threading.Tasks;
using Dominio;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Aplicacion.Parentescos;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParentescoController : ControllerBase
    {
        
        private readonly IMediator _mediator;
        public ParentescoController (IMediator mediator){
            _mediator = mediator;
        }       

        [HttpGet]
        public async Task<ActionResult<List<Parentesco>>> Get(){
            return await _mediator.Send(new Consulta.ListaParentescos());    
        }
    }
}