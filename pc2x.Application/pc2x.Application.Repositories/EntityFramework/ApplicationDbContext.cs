
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

        public DbSet<Pais> Paises { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new PaisConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
