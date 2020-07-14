using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Municipio
    {
        [Key]
        public int CodMunicipio { get; set; }

        public string Descripcion { get; set; }
    }
}