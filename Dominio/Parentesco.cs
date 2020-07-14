using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Parentesco
    {       
        [Key]
        public int CodParentesco{ get; set; }
        
        public string Descripcion{ get; set; }
    }
}