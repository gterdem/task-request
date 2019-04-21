using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TaskRequest.Persistence.Domains;

namespace TaskRequest.Application.Roles.Commands.CreateRole
{
    public class CreateRoleCommandHandler : IRequestHandler<CreateRoleCommand, Guid>
    {
        private readonly RoleManager<ApplicationRole> _roleManager;
        public CreateRoleCommandHandler(RoleManager<ApplicationRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public async Task<Guid> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
        {
            var roleEntity = new ApplicationRole(request.Name);
            await _roleManager.CreateAsync(roleEntity);
            return roleEntity.Id;
        }
    }
}
