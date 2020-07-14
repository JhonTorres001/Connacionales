using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Dominio;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Parentescos
{
    public class Consulta
    {
         public class ListaParentescos : IRequest<List<Parentesco>> {}
        public class Manejador : IRequestHandler<ListaParentescos, List<Parentesco>>
        {
            private readonly CursoOlineContext _context;
            public Manejador(CursoOlineContext context){
               _context = context;
            }

            public  async Task<List<Parentesco>> Handle(ListaParentescos request, CancellationToken cancellationToken)
            {
                var Parentescos = await  _context.Parentesco.ToListAsync();
               return Parentescos;   
            }
        }
    }
}



           