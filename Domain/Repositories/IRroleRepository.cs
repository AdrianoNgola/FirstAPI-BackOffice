using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstAPI.Domain.Model;
using FirstAPI.Enums;

namespace FirstAPI.Domain.Repositories
{
    public interface IRroleRepository : IRepository<RoleModel>
    {
        // Métodos adicionais específicos para Role
       Task<IEnumerable<RoleModel>> GetByPermissionTypeAsync(PermissionType type);
    }
}