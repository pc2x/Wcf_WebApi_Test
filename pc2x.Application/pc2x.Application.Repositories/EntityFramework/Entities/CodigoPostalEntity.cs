
namespace pc2x.Application.Repositories.EntityFramework.Entities
{
    public class CodigoPostalEntity
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public AsentamientoEntity Asentamiento { get; set; }
    }
}
