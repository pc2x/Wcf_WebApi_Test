
using System.Collections.Generic;

namespace pc2x.Application.Repositories.EntityFramework.Entities
{
    public class PaisEntity
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }

        //estados child
        public ICollection<EstadoEntity> Estados { get; set; }
    }
}
