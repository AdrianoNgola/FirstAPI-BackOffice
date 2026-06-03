using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FirstAPI.Infrastrutura
{
    public class ConnectionContext: DbContext
    {
        public DbSet<Model.EmployeeModel> Employee { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseNpgsql("Host=localhost;Port=5050;Database=Employee;Username=postgres;Password=E1000018869");
        }
    }
}