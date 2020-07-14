
using System.ComponentModel.DataAnnotations;
namespace Dominio
{
    public class Departamento
    {
        [Key]
        public int CodDepartamento { get; set; }

        public string Descripcion { get; set; }
        
    }
}