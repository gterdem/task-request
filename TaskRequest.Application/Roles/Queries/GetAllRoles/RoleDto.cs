using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using TaskRequest.Application.Interfaces.Mapping;
using TaskRequest.Persistence.Domains;

namespace TaskRequest.Application.Roles.Queries.GetAllRoles
{
    public class RoleDto : IHaveCustomMapping
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<ApplicationRole, RoleDto>();
        }
    }
}
