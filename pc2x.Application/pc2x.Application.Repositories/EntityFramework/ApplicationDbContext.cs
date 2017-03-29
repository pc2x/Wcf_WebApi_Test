using pc2x.Application.Repositories.EntityFramework.Entities;
using pc2x.Application.Repositories.EntityFramework.EntitiesConfiguration;
using System.Data.Entity;

namespace pc2x.Application.Repositories.EntityFramework
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("ApplicationDbContext")
        {

        }

        public DbSet<PaisEntity> Paises { get; set; }
        public DbSet<EstadoEntity> Estados { get; set; }
        public DbSet<MunicipioEntity> Municipios { get; set; }
        public DbSet<TipoAsentamientoEntity> TiposAsentamientos { get; set; }
        public DbSet<AsentamientoEntity> Asentamientos { get; set; }
        public DbSet<CodigoPostalEntity> CodigosPostales { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PaisConfiguration());
            modelBuilder.Configurations.Add(new EstadoConfiguration());
            modelBuilder.Configurations.Add(new MunicipioConfiguracion());
            modelBuilder.Configurations.Add(new TipoAsentamientoConfiguration());
            modelBuilder.Configurations.Add(new AsentamientoConfiguration());
            modelBuilder.Configurations.Add(new CodigoPostalConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }


}