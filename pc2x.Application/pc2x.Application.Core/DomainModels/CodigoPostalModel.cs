
namespace pc2x.Application.Core.DomainModels
{
    public class CodigoPostalModel
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public AsentamientoModel Asentamiento { get; set; }
    }
}
