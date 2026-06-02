using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstAPI.Enums;

namespace FirstAPI.Domain.DTOs.Role.Request
{
    public class AddRoleRequest
    {
        public PermissionType Type { get; set; }
        public string? Description { get; set; }
    }
}