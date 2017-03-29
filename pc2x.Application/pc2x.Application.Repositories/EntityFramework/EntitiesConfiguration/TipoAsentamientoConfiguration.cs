
using pc2x.Application.Repositories.EntityFramework.Entities;
using System.Data.Entity.ModelConfiguration;

namespace pc2x.Application.Repositories.EntityFramework.EntitiesConfiguration
{
    public class TipoAsentamientoConfiguration : EntityTypeConfiguration<TipoAsentamientoEntity>
    {
        public TipoAsentamientoConfiguration()
        {
            //table name
            Map(m => m.ToTable("TipoAsentamientos"));

            //add primary key
            HasKey(m => m.Id);

            //Required Field
            Property(m => m.Nombre)
                .HasColumnName("Nombre")
                .HasColumnType("nvarchar")
                .HasMaxLength(100)
                .IsRequired()
                .IsUnique();
        }
    }
}
