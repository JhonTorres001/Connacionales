using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Nacionalidad
    {

        [Key]
        public int CodNacionalidad{ get; set; }
        public string Descripcion{ get; set; }
    }
}