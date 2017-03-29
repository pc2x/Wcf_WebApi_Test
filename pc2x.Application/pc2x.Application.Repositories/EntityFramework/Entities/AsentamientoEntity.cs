namespace pc2x.Application.Repositories.EntityFramework.Entities
{
    public class AsentamientoEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public MunicipioEntity Municipio { get; set; }
        public int MunicipioId { get; set; }
        public TipoAsentamientoEntity TipoAsentamiento { get; set; }

    }
}
