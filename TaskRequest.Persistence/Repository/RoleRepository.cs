using MongoDbGenericRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TaskRequest.Persistence.Context;
using TaskRequest.Persistence.Domains;
using TaskRequest.Persistence.IRepository;
using System.Linq;
using MongoDB.Driver;

namespace TaskRequest.Persistence.Repository
{
    public class RoleRepository : IRoleRepository
    {
        private readonly ITaskRequestContext _context;
        public RoleRepository(ITaskRequestContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ApplicationRole>> GetAllRolesAsync()
        {
            return await _context
                .Roles
                .Find(_ => true)
                .ToListAsync();
        }
    }
}
