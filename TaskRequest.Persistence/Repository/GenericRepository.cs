using MongoDB.Driver;
using MongoDbGenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TaskRequest.Persistence.IRepository;

namespace TaskRequest.Persistence.Repository
{
    public class GenericRepository : BaseMongoRepository, IGenericRepository
    {
        public GenericRepository(IMongoDbContext mongoDbContex) : base(mongoDbContex)
        {

        }
    }
}
