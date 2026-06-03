using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstAPI.Domain.Model;
using FirstAPI.Enums;

namespace FirstAPI.Application.Services.Role.Interface
{
    public interface IRoleService
    {
         Task<IEnumerable<RoleModel>> GetAllRolesAsync();
        Task<RoleModel?> GetRoleByIdAsync(Guid id);
        Task<RoleModel> CreateRoleAsync(PermissionType type, string? description);
        Task<RoleModel?> UpdateRoleAsync(Guid id, PermissionType type, string? description);
        Task<bool> DeleteRoleAsync(Guid id);
        
    }
}