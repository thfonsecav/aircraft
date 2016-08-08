using Aircraft.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace Aircraft.DA
{
    public class AircraftContext : DbContext
    {

        public AircraftContext() : base("Aircraft")
        {
            this.Configuration.ProxyCreationEnabled = true;
            this.Configuration.LazyLoadingEnabled = true;
        }
        public DbSet<Aerolinea> Aereolinea { get; set; }
        public DbSet<Aeropuerto> Aeropuerto { get; set; }
        public DbSet<Avion> Avion { get; set; }
        public DbSet<Pais> Pais { get; set; }
        public DbSet<Puesto> puesto { get; set; }
        public DbSet<Reservacion> Reservacion { get; set; }
        public DbSet<Vuelo> Vuelo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Previene que la tabla de la base de datos sea pluralizada. Ej: (Persona => Personas)
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
