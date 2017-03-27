
using System.Data.Entity;

namespace pc2x.Application.Repositories
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("ApplicationDbContext")
        {

        }
    }
}
