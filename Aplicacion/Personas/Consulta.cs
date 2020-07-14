using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Dominio;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Personas
{
    public class Consultar
    {
        public class ListaPersonas : IRequest<List<Persona>> {}

        public class Manejador : IRequestHandler<ListaPersonas, List<Persona>>
        {
             private readonly CursoOlineContext _context;
            public Manejador(CursoOlineContext context){
                _context = context;
            } 
            public async Task<List<Persona>> Handle(ListaPersonas request, CancellationToken cancellationToken)
            {
               
                var Cursos = await  _context.Persona.ToListAsync();
                return Cursos;  


            }
        }
    }
}