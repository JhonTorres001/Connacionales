using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Dominio;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Estados
{
    public class Consulta
    {
         public class ListaEstado : IRequest<List<Estado>> {}

        public class Manejador : IRequestHandler<ListaEstado, List<Estado>>
        {


            private readonly CursoOlineContext _context;

            public Manejador(CursoOlineContext context){
               _context = context;
            }   

            public  async Task<List<Estado>> Handle(ListaEstado request, CancellationToken cancellationToken)
            {              
                var Estados = await  _context.Estado.ToListAsync();
                return Estados;            
            }
        }
    }
}