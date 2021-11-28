using System;
using System.Threading.Tasks;
using AdultsServer.Data;
using AdultsServer.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdultsServer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IAdultsService userService;

        public UsersController(IAdultsService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<User>> ValidateUser([FromQuery] string username, [FromQuery] string password)
        {
            Console.WriteLine("Here");
            try
            {
                Console.WriteLine(username);
                Console.WriteLine(password);
                var user = await userService.ReadAsync(username, password);
                Console.WriteLine(user.ToString());
                return Ok(user);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
                
            }
        }
        [HttpPost]
        public async Task<ActionResult<User>> AddUserAsync([FromBody] User user) {
            try {
                User newUser = await userService.AddUser(user);
                return Created($"/{newUser.UserName}", newUser);
            }
            catch (Exception e) {
                return StatusCode(500, e.Message);
            }
        }
        
    }
}