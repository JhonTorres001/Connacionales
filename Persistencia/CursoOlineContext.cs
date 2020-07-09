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

    }
}