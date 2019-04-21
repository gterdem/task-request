using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace TaskRequest.Application.Roles.Commands.CreateRole
{
    public class CreateRoleCommand : IRequest<Guid>
    {
        public string Name { get; set; }
    }
}
