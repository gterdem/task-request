using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDbGenericRepository.Attributes;
using MongoDbGenericRepository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace TaskRequest.Persistence.Domains
{
    [CollectionName("Tasks")]
    public class TaskEntity : IDocument
    {
        public Guid Id { get; set; }
        public string Content { get; private set; }
        public string FromUser { get; private set; }
        public string AssignedUser { get; set; }
        public BsonDateTime CreatedDate { get; private set; }
        public BsonDateTime CompletedDate { get; private set; }
        public BsonDateTime StatusChangeDate { get; set; }
        public TaskStatus Status { get; set; }
        public int Version { get; set; }


        protected TaskEntity()
        {

        }
        public TaskEntity(string content, string from, int? version)
        {
            Id = Guid.NewGuid();
            Content = content;
            FromUser = from;
            CreatedDate = new BsonDateTime(DateTime.UtcNow);
            Status = TaskStatus.Free;
            Version = version.HasValue ? version.Value : 1;
        }
    }

    public enum TaskStatus
    {
        Free = 1,
        OnProcess = 2,
        Resolved = 3,
        Rejected = 4
    }
}
