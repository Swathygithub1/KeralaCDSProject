using KeralaCDS.Services;
using Microsoft.AspNetCore.Mvc;
using KeralaCDS.Models;
using System.Reflection.Metadata.Ecma335;

namespace KeralaCDS.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
   
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
            
        }

        [HttpPost]
        [Route("CDSUserRegistration")]

        public async Task<IActionResult> CDSUserRegistration(UserDTO userdto)
        {
            await _userService.RegisterUser(userdto);
            return Ok();
        }



    }
}
