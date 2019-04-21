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
            var roleEntity = new ApplicationRole(request.Name);
            var result = await _roleManager.CreateAsync(roleEntity);
            if (result.Succeeded)
            {
                return roleEntity.Id;
            }
            else
            {
                var dodo = result.Errors;
            }

            //await _mediator.Publish(new CustomerCreated { CustomerId = entity.CustomerId }, cancellationToken);
            return roleEntity.Id;
        }
    }
}
