using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstAPI.Enums;

namespace FirstAPI.Domain.Model
{
    public class RoleModel
    {
        public Guid RoleId { get; set; }
        public PermissionType Type { get; set; } // Ex.: Admin, Editor
        public string? Description { get; set; }

        public ICollection<UserModel> Users { get; set; }

        public RoleModel()
    {
        RoleId = Guid.NewGuid(); // Gera automaticamente um novo GUID
        Users = new List<UserModel>(); // Inicializa a coleção para evitar null
    }

    // Construtor com parâmetros
    public RoleModel(PermissionType type, string? description = null)
    {
        RoleId = Guid.NewGuid();
        Type = type;
        Description = description;
        Users = new List<UserModel>();
    }
        
    }
}