using pc2x.Application.Core.DomainModels;
using pc2x.Application.Core.ServicesContracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace pc2x.Application.WebServices.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ApplicationService : IPaisContract
    {
        private readonly IPaisService _paisService;

        public ApplicationService()
            : this(Bootsrapper.Container.GetInstance<IPaisService>())
        {

        }

        protected ApplicationService(IPaisService paisService)
        {
            _paisService = paisService;
        }

        public async Task<PaisModel> AddAsync(PaisModel model)
        {
            var task = await _paisService.Add(model);
            return task;
        }

        public IEnumerable<PaisModel> GetAll()
        {
            return _paisService.GetAll();
        }

        public async Task Edit(PaisModel model)
        {
            await _paisService.Edit(model);
        }

        public async Task Delete(PaisModel model)
        {
            await _paisService.Delete(model);
        }
    }
}
