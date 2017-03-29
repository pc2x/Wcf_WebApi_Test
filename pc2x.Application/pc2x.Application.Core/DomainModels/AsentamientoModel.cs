
namespace pc2x.Application.Core.DomainModels
{
    public class AsentamientoModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public MunicipioModel Municipio { get; set; }
        public int MunicipioId { get; set; }
        public TipoAsentamientoModel TipoAsentamiento { get; set; }
    }
}
