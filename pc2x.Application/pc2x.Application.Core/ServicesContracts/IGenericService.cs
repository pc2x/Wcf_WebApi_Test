using System.Collections.Generic;
using System.Threading.Tasks;

namespace pc2x.Application.Core.ServicesContracts
{
    public interface IGenericService<T>
    {
        Task<T> Add(T model);
        IEnumerable<T> GetAll();
        Task Edit(T model);
        Task Delete(T model);
    }
}