using AspNetCore.Identity.MongoDbCore.Models;
using MongoDbGenericRepository.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace TaskRequest.Persistence.Domains
{
    [CollectionName("Users")]
    public class ApplicationUser : MongoIdentityUser<Guid>
    {
        public ApplicationUser() : base()
        {
        }

        public ApplicationUser(string userName, string email) : base(userName, email)
        {
        }
    }
}
