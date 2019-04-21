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
        private readonly IGenericRepository _repository;
        private readonly IMapper _mapper;
        public GetAllRolesQueryHandler(IGenericRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<RoleDto>> Handle(GetAllRolesQuery request, CancellationToken cancellationToken)
        {
            //var roleEntities = await _repository.GetAllAsync<ApplicationRole>(role => true);            
            //var roles = _mapper.Map<IEnumerable<RoleDto>>(roleEntities).ToList();
            return new List<RoleDto>();
            //return roles;
        }
    }
}
