using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstAPI.Domain.Model;
using FirstAPI.Domain.Repositories;
using FirstAPI.Enums;
using Microsoft.EntityFrameworkCore;

namespace FirstAPI.Infrastrutura.Repositories
{
    public class RoleRepository : IRroleRepository
    {
        private readonly DbContext _context;

    public RoleRepository(DbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<RoleModel>> GetAllAsync()
    {
        return await _context.Set<RoleModel>().Include(r => r.Users).ToListAsync();
    }

    public async Task<RoleModel?> GetByIdAsync(Guid id)
    {
        return await _context.Set<RoleModel>()
                             .Include(r => r.Users)
                             .FirstOrDefaultAsync(r => r.RoleId == id);
    }

    public async Task AddAsync(RoleModel entity)
    {
        await _context.Set<RoleModel>().AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(RoleModel entity)
    {
        _context.Set<RoleModel>().Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var role = await GetByIdAsync(id);
        if (role != null)
        {
            _context.Set<RoleModel>().Remove(role);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<RoleModel>> GetByPermissionTypeAsync(PermissionType type)
    {
        return await _context.Set<RoleModel>()
                             .Where(r => r.Type == type)
                             .Include(r => r.Users)
                             .ToListAsync();
    }
    }
}