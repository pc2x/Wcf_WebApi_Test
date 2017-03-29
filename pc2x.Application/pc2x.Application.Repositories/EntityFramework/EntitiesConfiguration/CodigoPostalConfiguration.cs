using pc2x.Application.Repositories.EntityFramework.Entities;
using System.Data.Entity.ModelConfiguration;

namespace pc2x.Application.Repositories.EntityFramework.EntitiesConfiguration
{
    class CodigoPostalConfiguration : EntityTypeConfiguration<CodigoPostalEntity>
    {
        public CodigoPostalConfiguration()
        {
            //table name
            Map(m => m.ToTable("CodigosPostales"));

            //add primary key
            HasKey(m => m.Id);

            //Required Field
            Property(m => m.Codigo)
                .HasColumnName("Codigo")
                .HasColumnType("varchar")
                .HasMaxLength(7)
                .IsRequired()
                .IsUnique();

            HasRequired(m => m.Asentamiento);
        }
    }
}
