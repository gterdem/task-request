using AspNetCore.Identity.MongoDbCore.Extensions;
using AspNetCore.Identity.MongoDbCore.Infrastructure;
using Microsoft.AspNetCore.Identity;
using System;
using TaskRequest.Persistence.Config;
using TaskRequest.Persistence.Context;
using TaskRequest.Persistence.Domains;
using TaskRequest.Persistence.IRepository;
using TaskRequest.Persistence.Repository;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ConfigurationExtensions
    {
        public static IServiceCollection AddTaskRequestMongoDb(this IServiceCollection services, ServerConfig config)
        {
            //var taskContext = new TaskContext(config.MongoDB);


            //var mongoDbContext = new MongoDbContext("mongodb://localhost:27017", "MongoDbTests");
            var taskDbContext = new TaskRequestContext(config);
            //var taskDbContext = new TaskRequestContext("mongodb://localhost:27017", config.MongoDB.Database);
            services.AddIdentity<ApplicationUser, ApplicationRole>()
                .AddMongoDbStores<ApplicationUser, ApplicationRole, Guid>(taskDbContext)
                .AddDefaultTokenProviders();
            //var mongoDbIdentityConfiguration = new MongoDbIdentityConfiguration
            //{
            //    MongoDbSettings = new MongoDbSettings
            //    {
            //        ConnectionString = config.MongoDB.ConnectionString,
            //        DatabaseName = config.MongoDB.Database
            //    },
            //    IdentityOptionsAction = options =>
            //    {
            //        options.Password.RequireDigit = false;
            //        options.Password.RequiredLength = 8;
            //        options.Password.RequireNonAlphanumeric = false;
            //        options.Password.RequireUppercase = false;
            //        options.Password.RequireLowercase = false;

            //        // Lockout settings
            //        options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
            //        options.Lockout.MaxFailedAccessAttempts = 10;

            //        // ApplicationUser settings
            //        options.User.RequireUniqueEmail = true;
            //        options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789@.-_";
            //    }
            //};
            //services.ConfigureMongoDbIdentity<ApplicationUser, ApplicationRole, Guid>(mongoDbIdentityConfiguration);

            //var genericRepo = new GenericRepository(taskDbContext);
            //services.AddSingleton<IGenericRepository>(genericRepo);

            return services;
        }
    }
}
