using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstAPI.Enums;

namespace FirstAPI.Domain.DTOs.Role.Response
{
    public class RoleResponse
    {
       public Guid RoleId { get; set; }
        public PermissionType Type { get; set; }
        public string? Description { get; set; }
        //public ICollection<UserReadDto> Users { get; set; }
    }
}