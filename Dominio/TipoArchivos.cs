using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class TipoArchivos
    {
        [Key]
        public int CodTipoArchivo { get; set; }
        public string Descriocion{ get; set; }
    }
}