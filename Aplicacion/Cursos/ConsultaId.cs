using System.Threading;
using System.Threading.Tasks;
using Dominio;
using MediatR;
using Persistencia;

namespace Aplicacion.Cursos
{
    public class ConsultaId
    {
        public class CursoUnico : IRequest<Curso> {
            public int Id { get; set; }
        }
        public class Manejador : IRequestHandler<CursoUnico, Curso>
        {

            private readonly CursoOlineContext _context;
            public Manejador(CursoOlineContext context){
                    _context = context;
            }
            public async Task<Curso> Handle(CursoUnico request, CancellationToken cancellationToken)
            {
                var Cursos = await  _context.Curso.FindAsync(request.Id);
                return Cursos;
            }
        }
    }
}