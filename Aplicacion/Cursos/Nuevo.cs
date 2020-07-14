using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;
using Dominio;
using MediatR;
using Persistencia;

namespace Aplicacion.Cursos
{
    public class Nuevo
    {
        

        public class  Ejecutar : IRequest {

            [Required(ErrorMessage="Debe ingresar el titulo")]
            public string titulo { get; set; } 
            public string descripcion { get; set; }
            public DateTime fechaPublicacion { get; set; }

        }
        public class Manejador : IRequestHandler<Ejecutar>
        {

            private readonly CursoOlineContext _context;
            public Manejador(CursoOlineContext context){
                    _context = context;
            }
            public async Task<Unit> Handle(Ejecutar request, CancellationToken cancellationToken)
            {
                var curso = new Curso {
                        Titulo = request.titulo,
                        Descripcion = request.descripcion,
                        FechaPublicacion = request.fechaPublicacion             

                };

                _context.Curso.Add(curso);
               var valor =  await _context.SaveChangesAsync();

                if (valor > 0)
                {
                   return Unit.Value;
                }
                throw new Exception("No se pudo insertar"); 
            }
        }

    }
}