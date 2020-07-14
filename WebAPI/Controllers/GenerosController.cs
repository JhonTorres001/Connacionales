using System.Collections.Generic;
using System.Threading.Tasks;
using Dominio;
using MediatR;
using Aplicacion.Generos;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenerosController : ControllerBase
    {
        private readonly IMediator _mediator;
        public GenerosController(IMediator mediator){
            _mediator = mediator;
        }       

        [HttpGet]
        public async Task<ActionResult<List<Genero>>> Get(){
            return await _mediator.Send(new Consulta.ListaGeneros());    
        }
    }
}