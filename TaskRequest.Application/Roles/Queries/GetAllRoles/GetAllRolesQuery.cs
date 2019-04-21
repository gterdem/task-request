using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace TaskRequest.Application.Roles.Queries.GetAllRoles
{
    public class GetAllRolesQuery : IRequest<List<RoleDto>>
    {
    }
}
