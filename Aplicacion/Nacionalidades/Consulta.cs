using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Dominio;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Nacionalidades
{
    public class Consulta
    {
        public class ListaNacionalidades : IRequest<List<Nacionalidad>> {}
        public class Manejador : IRequestHandler<ListaNacionalidades, List<Nacionalidad>>
        {
            private readonly CursoOlineContext _context;
            public Manejador(CursoOlineContext context){
               _context = context;
            }

            public  async Task<List<Nacionalidad>> Handle(ListaNacionalidades request, CancellationToken cancellationToken)
            {
               var Nacionalidades = await  _context.Nacionalidad.ToListAsync();
               return Nacionalidades;                
            }
        }
    }
}


  