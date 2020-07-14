using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Genero
    {

        [Key]
        public int CodGenero { get; set; }
        public string Descripcion { get; set; }  
    }
}