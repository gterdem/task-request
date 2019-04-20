using TaskRequest.Config;

namespace TaskRequest.Persistence.Config
{
    public class ServerConfig
    {
        public MongoDBConfig MongoDB { get; set; } = new MongoDBConfig();
    }
}
