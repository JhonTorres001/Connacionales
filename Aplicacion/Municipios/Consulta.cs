using System.Collections.Generic;
using System.Threading;
using Dominio;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Municipios
{
    public class Consulta
    {
        public class ListaMunicipios : IRequest<List<Municipio>> {}
        public class Manejador : IRequestHandler<ListaMunicipios, List<Municipio>>
        {
            private readonly CursoOlineContext _context;
            public Manejador(CursoOlineContext context){
               _context = context;
            }  
            public async System.Threading.Tasks.Task<List<Municipio>> Handle(ListaMunicipios request, CancellationToken cancellationToken)
            {        
               var Municipios = await  _context.Municipio.ToListAsync();
               return Municipios;           
            }
        }
    }
}


 
