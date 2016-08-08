using Aircraft.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;



namespace Aircraft.DA
{
    public class AircraftContext : IdentityDbContext<User>
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
            base.OnModelCreating(modelBuilder);
        }
        public static AircraftContext Create()
        {
            return new AircraftContext();
        }
    }
}
