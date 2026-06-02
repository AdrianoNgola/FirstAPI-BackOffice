using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAPI.Domain.DTOs.Employee.Response
{
    public class EmployeeResponse
    {
       
        public string? name { get; set; }
        public int age { get; set; }

        public IFormFile? photo { get; set; }
    }
}