using System;
using System.Data.Entity;
using System.Linq;

namespace Instituciones.Models
{
    public class Empleo : DbContext
    {
        // El contexto se ha configurado para usar una cadena de conexión 'Empleo' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'Instituciones.Models.Empleo' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'Empleo'  en el archivo de configuración de la aplicación.
        public Empleo()
            : base("name=Empleo")
        {
        }

        public DbSet<Instituciones.Models.empresa> Institucions { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Institucion>()
                .HasKey(c => c.codigo);
            modelBuilder.Entity<Persona>()
                .HasKey(c => c.idPersona);
            modelBuilder.Entity<Referente>()
                .HasKey(c => c.idPersona)
                .HasRequired(x => x.empresa);
            
        }

       
    }

    
}