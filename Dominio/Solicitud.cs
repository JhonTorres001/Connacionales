using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Solicitud
    {  
        [Key]
        public int CodSolicitud{ get; set; }
        public System.DateTime FechaSolicitud { get; set; }
        public string NroIdent_Solicitante { get; set; }     
        public int CodEstado{ get; set; }
    }
}