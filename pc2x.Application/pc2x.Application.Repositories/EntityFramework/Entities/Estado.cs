
using System.Collections.Generic;

namespace pc2x.Application.Repositories.EntityFramework.Entities
{
    public class Estado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }

        //municipios child
        public ICollection<Municipio> Municipios { get; set; }

        //pais parent foreign
        public int PaisId { get; set; }
        public Pais Pais { get; set; }
    }
}
