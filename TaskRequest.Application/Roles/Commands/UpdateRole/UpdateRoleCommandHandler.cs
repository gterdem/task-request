using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TaskRequest.Application.Exceptions;
using TaskRequest.Persistence.Domains;

namespace TaskRequest.Application.Roles.Commands.UpdateRole
{
    public class UpdateRoleCommandHandler : IRequestHandler<UpdateRoleCommand>
    {
        private readonly RoleManager<ApplicationRole> _roleManager;
        public UpdateRoleCommandHandler(RoleManager<ApplicationRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public async Task<Unit> Handle(UpdateRoleCommand request, CancellationToken cancellationToken)
        {
            var existingEntity = await _roleManager.FindByIdAsync(request.RoleId);
            if (existingEntity == null)
            {
                throw new NotFoundException(nameof(existingEntity), request.RoleId);
            }
            existingEntity.Name = request.Name;
            //await _roleManager.UpdateAsync(existingEntity);
            await _roleManager.SetRoleNameAsync(existingEntity, request.Name);

            return Unit.Value;
        }
    }
}
