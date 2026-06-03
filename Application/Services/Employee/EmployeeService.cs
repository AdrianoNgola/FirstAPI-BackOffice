using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstAPI.Infrastrutura;
using FirstAPI.Model;
using FirstAPI.Services.Employee.Interface;
using Microsoft.EntityFrameworkCore;

namespace FirstAPI.Services.Employee
{
    public class EmployeeService: IEmployeeService
    {
        public readonly ConnectionContext _context = new ConnectionContext();

        public void AddEmployee(EmployeeModel employee)
        {
            _context.Employee.Add(employee);
            _context.SaveChanges();
        }
    }
}