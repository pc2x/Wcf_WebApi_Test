using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration.Configuration;

public static class MappinExtensions
{
    public static PrimitivePropertyConfiguration IsUnique(this PrimitivePropertyConfiguration configuration)
    {
        return configuration.HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute { IsUnique = true }));
    }
}