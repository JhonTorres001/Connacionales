using System.Collections.Generic;
using System.Threading;
using Dominio;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Generos
{
    public class Consulta
    {      
        public class ListaGeneros : IRequest<List<Genero>> {}
        public class Manejador : IRequestHandler<ListaGeneros, List<Genero>>
        {
            private readonly CursoOlineContext _context;
            public Manejador(CursoOlineContext context){
               _context = context;
            }   
            public async System.Threading.Tasks.Task<List<Genero>> Handle(ListaGeneros request, CancellationToken cancellationToken)
            {
               var Generos = await  _context.Genero.ToListAsync();
               return Generos;         
            }
        }
    }
}
