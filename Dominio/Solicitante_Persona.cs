using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Solicitante_Persona
    {
        [Key]
        public string NroIdent_Solicitante{ get; set; }
        public string  NroIdent_Persona { get; set; }
        public int CodParentesco { get; set; }
    }
}