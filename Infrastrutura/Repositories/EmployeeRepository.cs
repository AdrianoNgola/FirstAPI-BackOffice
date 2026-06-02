using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstAPI.Model;
using Microsoft.AspNetCore.Authorization;

namespace FirstAPI.Infrastrutura
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public readonly ConnectionContext _context = new ConnectionContext();

        
        public List<EmployeeModel> GetAllEmployees(int pageNumer, int pageQuantity)
        {
            
            return _context.Employee.Skip(pageNumer * pageQuantity).Take(pageQuantity).ToList();
        }

         
        public EmployeeModel? GetEmployeeById(int id)
        {
            return _context.Employee.Find(id);
        }
    }
}