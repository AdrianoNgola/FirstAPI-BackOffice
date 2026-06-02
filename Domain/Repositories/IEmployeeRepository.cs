using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAPI.Model
{
    public interface IEmployeeRepository
    {
        public List<EmployeeModel> GetAllEmployees(int pageNumber, int pageQuantity);
        
        public EmployeeModel? GetEmployeeById(int id);
    }
}