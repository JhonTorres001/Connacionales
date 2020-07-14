using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Persona
    {
        [Key]
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
}