namespace pc2x.Application.Repositories.EntityFramework.Entities
{
    public class Municipio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }

        //parent foreign
        public int EstadoId { get; set; }
        public Estado Estado { get; set; }
    }
}
