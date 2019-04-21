using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace TaskRequest.Application.Roles.Commands.UpdateRole
{
    public class UpdateRoleCommand : IRequest
    {
        public string RoleId { get; set; }
        public string Name { get; set; }
    }
}
