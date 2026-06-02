using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAPI.ViewModel
{
    public class EmployeeRequest
    {
        public int id { get; set; }
        public string? name { get; set; }
        public int age { get; set; }

        public IFormFile? photo { get; set; }
       
    }
}