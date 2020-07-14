using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Estado
    {

       [Key]
        public int CodEstado { get; set; }

        public string Descripcion { get; set; }
    }
}