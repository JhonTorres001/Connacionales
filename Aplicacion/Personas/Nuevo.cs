using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;
using Dominio;
using MediatR;
using Persistencia;

namespace Aplicacion.Personas
{
    public class Nuevo
    {
        public class  Ejecutar : IRequest {
            public string NroIdent { get; set; }
            public int CodTipoIdent { get; set; }
            public string Nombres { get; set; }
            public string Apellidos{ get; set; }
            public string Email {get; set; }
            public System.DateTime FechaNacimiento {get; set; }
            public string NroContacto {get; set; }
            public int CodGenero{ get; set; }
            public int CodNacionalidad{ get; set; }
            public int CodMunicipio{ get; set; }
            public int CodDepartamento{ get; set; }
        }

        public class Manejador : IRequestHandler<Ejecutar>
        {
            private readonly CursoOlineContext _context;
            public Manejador(CursoOlineContext context){
                    _context = context;
            }
         
            public async Task<Unit> Handle(Ejecutar request, CancellationToken cancellationToken)
            {
                 var objPersona = new Persona {
                    
                     NroIdent = request.NroIdent,
                     CodTipoIdent = request.CodTipoIdent,
                     Nombres = request.Nombres,
                     Apellidos = request.Apellidos,
                     Email = request.Email,
                     FechaNacimiento = request.FechaNacimiento,
                     NroContacto = request.NroContacto,
                     CodGenero = request.CodGenero,
                     CodNacionalidad = request.CodNacionalidad,
                     CodMunicipio =request.CodDepartamento ,
                     CodDepartamento = request.CodDepartamento               
                                    
                };



               _context.Persona.Add(objPersona);
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
