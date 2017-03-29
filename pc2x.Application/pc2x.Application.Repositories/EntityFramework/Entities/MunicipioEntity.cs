using System.Collections.Generic;

namespace pc2x.Application.Repositories.EntityFramework.Entities
{
    public class MunicipioEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }

        //parent foreign
        public int EstadoId { get; set; }
        public EstadoEntity Estado { get; set; }

        public ICollection<AsentamientoEntity> Asentamientos { get; set; }
    }
}
