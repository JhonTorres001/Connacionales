using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Dominio;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Solicitantes
{
    public class Consulta
    {
        public class ListaSolicitante : IRequest<List<Solicitante>> {}

        public class Manejador : IRequestHandler<ListaSolicitante, List<Solicitante>>
        {
            private readonly CursoOlineContext _context;
            public Manejador(CursoOlineContext context){
                _context = context;
            }
            public async Task<List<Solicitante>> Handle(ListaSolicitante request, CancellationToken cancellationToken)
            {
                var Solicitantes = await  _context.Solicitante.ToListAsync();
                return Solicitantes;  
            }
        }
    }
}


      