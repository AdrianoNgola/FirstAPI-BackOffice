using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstAPI.Application.Services.Role.Interface;
using FirstAPI.Domain.Model;
using FirstAPI.Domain.Repositories;
using FirstAPI.Enums;
using FirstAPI.Infrastrutura.Repositories;

namespace FirstAPI.Application.Services.Role
{
    public class RoleService : IRoleService
    {
        private readonly IRroleRepository _roleRepository;

    public RoleService(RoleRepository roleRepository)
    {
        _roleRepository = roleRepository;
    }

    public async Task<IEnumerable<RoleModel>> GetAllRolesAsync()
    {
        return await _roleRepository.GetAllAsync();
    }

    public async Task<RoleModel?> GetRoleByIdAsync(Guid id)
    {
        return await _roleRepository.GetByIdAsync(id);
    }

    public async Task<RoleModel> CreateRoleAsync(PermissionType type, string? description)
    {
        var role = new RoleModel
        {
            RoleId = Guid.NewGuid(),
            Type = type,
            Description = description,
            Users = new List<UserModel>()
        };

        await _roleRepository.AddAsync(role);
        return role;
    }

    public async Task<RoleModel?> UpdateRoleAsync(Guid id, PermissionType type, string? description)
    {
        var role = await _roleRepository.GetByIdAsync(id);
        if (role == null) return null;

        role.Type = type;
        role.Description = description;

        await _roleRepository.UpdateAsync(role);
        return role;
    }

    public async Task<bool> DeleteRoleAsync(Guid id)
    {
        var role = await _roleRepository.GetByIdAsync(id);
        if (role == null) return false;

        await _roleRepository.DeleteAsync(id);
        return true;
    }
    }
}