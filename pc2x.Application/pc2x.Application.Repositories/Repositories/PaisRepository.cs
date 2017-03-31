
using pc2x.Application.Core.DomainModels;
using pc2x.Application.Core.RepositoriesContracts;
using pc2x.Application.Repositories.EntityFramework;
using pc2x.Application.Repositories.EntityFramework.Entities;
using pc2x.Application.Repositories.Mappers;

namespace pc2x.Application.Repositories.Repositories
{
    public class PaisRepository : GenericRepository<PaisEntity, PaisModel, ApplicationDbContext>, IPaisRepository
    {
        public PaisRepository()
        {
            AutoMapperConfiguration.Configure();
        }
    }
}
