using System.Collections.Generic;
using System.Threading.Tasks;
using Aplicacion.Departamentos;
using Dominio;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentosController: ControllerBase
    {
        private readonly IMediator _mediator;
        public DepartamentosController(IMediator mediator){
            _mediator = mediator;
        }       
        [HttpGet]
        public async Task<ActionResult<List<Departamento>>> Get(){
            return await _mediator.Send(new Consulta.ListaDepartamento());    
        }

        [HttpPost]
        public async Task<ActionResult<Unit>> Crear(Nuevo.Ejecutar pData)
        {
            return await _mediator.Send(pData);        
        }
    }
}