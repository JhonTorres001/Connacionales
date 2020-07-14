using System.Collections.Generic;
using System.Threading.Tasks;
using Aplicacion.Personas;
using Dominio;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {

        private readonly IMediator _mediator;
        public PersonasController(IMediator mediator){
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<Unit>> Crear(Nuevo.Ejecutar pData){          
            return await _mediator.Send(pData);        
        }

        [HttpGet]
        public async Task<ActionResult<List<Persona>>> Get(){
            return await _mediator.Send(new Aplicacion.Personas.Consultar.ListaPersonas());    
        }
    }
}