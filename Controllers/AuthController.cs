using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FirstAPI.Model;
using FirstAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FirstAPI.Controllers
{
    [ApiController]
    [Route("api/v1/auth")]
    public class AuthController : Controller
    {
       [HttpPost]
        public IActionResult Auth( string username, string password)
        {
            if (username == "admin" && password == "12345")
            {
                var employee = new EmployeeModel
                {
                        id = 1, // ou o id que você quiser
                        name = "Admin"
                };
                var token = TokenService.GenerateToken(employee);
                return Ok(token);
            }

            return BadRequest("Username or password invalid");
            
                
        }
    }
}