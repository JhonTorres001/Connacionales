using System.Collections.Generic;
using System.Threading.Tasks;
using Aplicacion.Cursos;
using Dominio;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{

        
    [Route("api/[controller]")]
    [ApiController]
    public class CursosController : ControllerBase
    {

        private readonly IMediator _mediator;
        public CursosController(IMediator mediator){
            _mediator = mediator;
        }
        //http://localhost:5003/api/Cursos
        [HttpGet]
        public async Task<ActionResult<List<Curso>>> Get(){
            return await _mediator.Send(new Consulta.ListaCursos());        
        }
        //http://localhost:5004/api/Cursos/1
        [HttpGet("{id}")]
        public async Task<ActionResult<Curso>> Detalle(int id){
            return await _mediator.Send(new ConsultaId.CursoUnico {Id = id});        
        }


        //http://localhost:5004/api/Cursos/1
        [HttpPost]
        public async Task<ActionResult<Unit>> Crear(Nuevo.Ejecutar pData){


            return await _mediator.Send(pData);        
        }

    }
}