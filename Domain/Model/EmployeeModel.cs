using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAPI.Model
{
    [Table("employee")]
    public class EmployeeModel
    {
        public int id { get; set; }
        public string? name { get; set; }
        public int age { get; set; }
        public string? photo { get; set; }


        public EmployeeModel()
        {
            
        }
        public EmployeeModel(int id, string? name, int age, string? photo)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.photo = photo;
        }

    }
}