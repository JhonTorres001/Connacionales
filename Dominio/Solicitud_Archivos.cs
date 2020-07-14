using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Solicitud_Archivos
    {

        [Key]
        public int CodSolicitud { get; set; }
        public int CodTipoArchivo { get; set; }
        public int Archivo { get; set; }
    }
}