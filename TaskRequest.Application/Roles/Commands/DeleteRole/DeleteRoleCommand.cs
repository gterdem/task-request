using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace TaskRequest.Application.Roles.Commands.DeleteRole
{
    public class DeleteRoleCommand : IRequest
    {
        public string RoleId { get; set; }
    }
}
