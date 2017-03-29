using pc2x.Application.Repositories.EntityFramework.Entities;
using System.Data.Entity.ModelConfiguration;

namespace pc2x.Application.Repositories.EntityFramework.EntitiesConfiguration
{
    public class PaisConfiguration : EntityTypeConfiguration<PaisEntity>
    {
        public PaisConfiguration()
        {
            //table name
            Map(m => m.ToTable("Paises"));

            //add primary key
            HasKey(m => m.Id);

            //Required Field
            Property(m => m.Nombre)
                .HasColumnName("Nombre")
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsRequired();

            Property(m => m.Codigo)
                .HasColumnName("Codigo")
                .HasColumnType("nvarchar")
                .HasMaxLength(5)
                .IsRequired();

            HasMany(m => m.Estados)
                .WithRequired(m => m.Pais)
                .HasForeignKey(m => m.PaisId)
                .WillCascadeOnDelete();

            //ignora un campo de mapear a la db
            //Ignore(m => m.Id);
        }
    }
}
