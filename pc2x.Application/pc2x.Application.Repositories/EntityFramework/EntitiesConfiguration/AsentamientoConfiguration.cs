using pc2x.Application.Repositories.EntityFramework.Entities;
using System.Data.Entity.ModelConfiguration;

namespace pc2x.Application.Repositories.EntityFramework.EntitiesConfiguration
{
    public class AsentamientoConfiguration : EntityTypeConfiguration<AsentamientoEntity>
    {
        public AsentamientoConfiguration()
        {
            //table name
            Map(m => m.ToTable("Asentamientos"));

            //add primary key
            HasKey(m => m.Id);

            //Required Field
            Property(m => m.Nombre)
                .HasColumnName("Nombre")
                .HasColumnType("nvarchar")
                .HasMaxLength(100)
                .IsRequired()
                .IsUnique();

            HasRequired(m => m.TipoAsentamiento);
        }
    }
}
