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
        private readonly IMediator _mediator;
        public CreateRoleCommandHandler(RoleManager<ApplicationRole> roleManager, IMediator mediator)
        {
            _roleManager = roleManager;
            _mediator = mediator;
        }
        public async Task<Guid> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrEmpty(request.Name))
            {
                throw new Exception("Role Name can not be null");
            }
            var roleEntity = new ApplicationRole(request.Name);
            var result = await _roleManager.CreateAsync(roleEntity);

            //await _mediator.Publish(new RoleCreated { RoleId = roleEntity.Id }, cancellationToken);
            return roleEntity.Id;
        }
    }
}
