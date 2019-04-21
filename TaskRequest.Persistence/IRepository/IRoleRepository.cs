using System.Collections.Generic;
using System.Threading.Tasks;
using TaskRequest.Persistence.Domains;

namespace TaskRequest.Persistence.IRepository
{
    public interface IRoleRepository
    {
        Task<IEnumerable<ApplicationRole>> GetAllRolesAsync();
    }
}
