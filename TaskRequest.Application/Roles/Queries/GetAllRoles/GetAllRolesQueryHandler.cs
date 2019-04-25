using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TaskRequest.Persistence.Domains;
using TaskRequest.Persistence.IRepository;

namespace TaskRequest.Application.Roles.Queries.GetAllRoles
{
    public class GetAllRolesQueryHandler : IRequestHandler<GetAllRolesQuery, List<RoleDto>>
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository _genericRepo;
        public GetAllRolesQueryHandler(IRoleRepository roleRepository, IMapper mapper, IGenericRepository genericRepo)
        {
            _mapper = mapper;
            _genericRepo = genericRepo;
        }

        public async Task<List<RoleDto>> Handle(GetAllRolesQuery request, CancellationToken cancellationToken)
        {
            var roleEntities = await _genericRepo.GetAllAsync<ApplicationRole>(_ => true);
            var roles = _mapper.Map<IEnumerable<RoleDto>>(roleEntities).ToList();
            return roles;
        }
    }
}
