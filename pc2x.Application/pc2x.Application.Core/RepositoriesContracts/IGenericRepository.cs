using System.Collections.Generic;
using System.Threading.Tasks;

namespace pc2x.Application.Core.RepositoriesContracts
{
    public interface IGenericRepository<TTarget>
        where TTarget : class
    {
        Task<TTarget> Add(TTarget model);
        IEnumerable<TTarget> GetAll();
        Task Edit(TTarget model);
        Task Delete(TTarget model);
    }
}