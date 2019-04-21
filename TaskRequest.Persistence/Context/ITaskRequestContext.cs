using MongoDB.Driver;
using MongoDbGenericRepository;
using System;
using System.Collections.Generic;
using System.Text;
using TaskRequest.Persistence.Domains;

namespace TaskRequest.Persistence.Context
{
    public interface ITaskRequestContext
    {
        IMongoCollection<TaskEntity> Tasks { get; }
    }
}
