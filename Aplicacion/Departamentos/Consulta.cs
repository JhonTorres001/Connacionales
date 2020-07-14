using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Dominio;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistencia;

namespace Aplicacion.Departamentos
{
    public class Consulta
    {
        public class ListaDepartamento : IRequest<List<Departamento>> {}

        public class Manejador : IRequestHandler<ListaDepartamento, List<Departamento>>
        {
            private readonly CursoOlineContext _context;
            public Manejador(CursoOlineContext context){
               _context = context;
            }   

            public async Task<List<Departamento>> Handle(ListaDepartamento request, CancellationToken cancellationToken)
            {             
                var Cursos = await  _context.Departamento.ToListAsync();
                return Cursos;
            }
        }
    }
}