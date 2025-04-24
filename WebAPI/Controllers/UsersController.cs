using Microsoft.AspNetCore.Mvc;
using WebAPI.Interfaces;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : Controller
    {
        private readonly IUsersBL _usersBL;

        public UsersController(IUsersBL usersBL)
        {
            _usersBL = usersBL;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            return Ok(await _usersBL.GetUsersAsync());
        }
    }
}
