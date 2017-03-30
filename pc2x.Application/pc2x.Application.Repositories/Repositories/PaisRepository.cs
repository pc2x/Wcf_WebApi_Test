
using pc2x.Application.Core.DomainModels;
using pc2x.Application.Core.ServicesContracts;
using pc2x.Application.Repositories.EntityFramework;
using pc2x.Application.Repositories.EntityFramework.Entities;
using pc2x.Application.Repositories.Mappers;

namespace pc2x.Application.Repositories.Repositories
{
    public class PaisRepository : GenericRepository<PaisEntity, PaisModel, ApplicationDbContext>, IPaisService
    {
        public PaisRepository()
        {
            AutoMapperConfiguration.Configure();
        }
    }
}
