using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;
using Dominio;
using MediatR;
using Persistencia;

namespace Aplicacion.Departamentos
{
    public class Nuevo
    {
        public class  Ejecutar : IRequest {
            public string Descripcion { get; set; }
        }

        public class Manejador : IRequestHandler<Ejecutar>
        {
            private readonly CursoOlineContext _context;
            public Manejador(CursoOlineContext context){
                    _context = context;
            }
            public async Task<Unit> Handle(Ejecutar request, CancellationToken cancellationToken)
            {
                var curso = new Departamento {
                        
                        Descripcion = request.Descripcion
                                 
                };
                _context.Departamento.Add(curso);
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

        
          
                
          