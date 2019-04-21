using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TaskRequest.Application.Exceptions;
using TaskRequest.Persistence.Domains;

namespace TaskRequest.Application.Roles.Commands.DeleteRole
{
    public class DeleteRoleCommandHandler : IRequestHandler<DeleteRoleCommand>
    {
        private readonly RoleManager<ApplicationRole> _roleManager;
        public DeleteRoleCommandHandler(RoleManager<ApplicationRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task<Unit> Handle(DeleteRoleCommand request, CancellationToken cancellationToken)
        {
            var existingEntity = await _roleManager.FindByIdAsync(request.RoleId);
            if (existingEntity == null)
            {
                throw new NotFoundException(nameof(existingEntity), request.RoleId);
            }
            await _roleManager.DeleteAsync(existingEntity);
            //Publish Role Deleted event for SignalR?
            return Unit.Value;
        }
    }
}
