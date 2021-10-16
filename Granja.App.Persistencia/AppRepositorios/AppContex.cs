using Microsoft.EntityFrameworkCore;
using Granja.App.Dominio;

namespace Granja.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas{ get; set; }

        public DbSet<Operario> Operarios{ get; set; }
        public DbSet<Veterinario> Veterinario{ get; set; }

        public DbSet<Galpon> Galpones{ get; set; }
        
        public DbSet<Historial> Historiales{get; set; }
        public DbSet<SugerenciaCuidado> SugerenciasCuidados{ get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog=GranjaTeamAData");
            }
        }
    }
}