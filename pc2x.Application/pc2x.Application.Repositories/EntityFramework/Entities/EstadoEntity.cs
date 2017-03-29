
using System.Collections.Generic;

namespace pc2x.Application.Repositories.EntityFramework.Entities
{
    public class EstadoEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }

        //municipios child
        public ICollection<MunicipioEntity> Municipios { get; set; }

        //pais parent foreign
        public int PaisId { get; set; }
        public PaisEntity Pais { get; set; }
    }
}
