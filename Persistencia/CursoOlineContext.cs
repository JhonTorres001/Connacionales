using Dominio;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class CursoOlineContext : DbContext
    {
        public CursoOlineContext(DbContextOptions options) : base(options){
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder){
        }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Genero> Genero { get; set; }
        public DbSet<Municipio> Municipio{ get; set; }
        public DbSet<Nacionalidad> Nacionalidad{ get; set; }       
        public DbSet<Parentesco> Parentesco{ get; set; }      
        
        public DbSet<Persona> Persona{ get; set; }        
        
        public DbSet<Solicitante> Solicitante{ get; set; }
        public DbSet<Solicitante_Persona> Solicitante_Persona{ get; set; } 
        public DbSet<Solicitud> Solicitud{ get; set; }        
        public DbSet<Solicitud_Archivos> Solicitud_Archivos {get; set; }
        public DbSet<TipoArchivos> TipoArchivos{get; set; }       
        public DbSet<TipoIdentificacion> TipoIdentificacion{get; set; }  
           
        // public DbSet<usuario> usario{get; set; }      
    }
}