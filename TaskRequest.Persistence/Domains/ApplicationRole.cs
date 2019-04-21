using AspNetCore.Identity.MongoDbCore.Models;
using MongoDbGenericRepository.Attributes;
using MongoDbGenericRepository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace TaskRequest.Persistence.Domains
{
    [CollectionName("Roles")]
    public class ApplicationRole : MongoIdentityRole<Guid>
    {
        public ApplicationRole() : base()
        {
        }

        public ApplicationRole(string roleName) : base(roleName)
        {
        }
    }
}
