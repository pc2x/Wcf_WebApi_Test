using pc2x.Application.Core.DomainModels;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading.Tasks;

namespace pc2x.Application.WebServices.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IPaisContract
    {
        [OperationContract]
        Task<PaisModel> AddAsync(PaisModel model);

        [OperationContract]
        IEnumerable<PaisModel> GetAll();

        [OperationContract]
        Task Edit(PaisModel model);

        [OperationContract]
        Task Delete(PaisModel model);
    }
}
