using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class TipoIdentificacion
    {
        [Key]
        public int CodTipoIndet { get; set; }
        public string Descripcion { get; set; }

    }
}