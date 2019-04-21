using MongoDB.Bson;
using MongoDB.Driver;
using MongoDbGenericRepository;
using System;
using System.Collections.Generic;
using System.Text;
using TaskRequest.Config;
using TaskRequest.Persistence.Config;
using TaskRequest.Persistence.Domains;

namespace TaskRequest.Persistence.Context
{
    public class TaskRequestContext : MongoDbContext, ITaskRequestContext
    {
        public TaskRequestContext(ServerConfig config) : base(config.MongoDB.ConnectionString, config.MongoDB.Database)
        {

        }
        public TaskRequestContext(string connectionString, string database):base(connectionString, database)
        {

        }
        //public IMongoCollection<ApplicationUser> Users => Database.GetCollection<ApplicationUser>("Users");
        //public IMongoCollection<ApplicationRole> Roles => Database.GetCollection<ApplicationRole>("Roles");
        public IMongoCollection<TaskEntity> Tasks => Database.GetCollection<TaskEntity>("Tasks");
    }
}
