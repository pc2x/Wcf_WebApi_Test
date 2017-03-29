using pc2x.Application.Core.DomainModels;
using pc2x.Application.Core.RepositoriesContracts;
using pc2x.Application.Core.ServicesContracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace pc2x.Application.Services.Services
{
    public class PaisServicio : IPaisService
    {
        private readonly IPaisRepository _paisRepository;
        public PaisServicio(IPaisRepository paisRepository)
        {
            _paisRepository = paisRepository;
        }

        public Task<PaisModel> Add(PaisModel model)
        {
            return _paisRepository.Add(model);
        }

        public IEnumerable<PaisModel> GetAll()
        {
            return _paisRepository.GetAll();
        }

        public Task Edit(PaisModel model)
        {
            return _paisRepository.Edit(model);
        }

        public Task Delete(PaisModel model)
        {
            return _paisRepository.Delete(model);
        }
    }
}
