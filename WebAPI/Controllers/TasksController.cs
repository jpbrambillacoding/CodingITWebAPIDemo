using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TasksController : Controller
    {
        private readonly ITaskBL _taskBL;

        public TasksController(ITaskBL taskBL)
        {
            _taskBL = taskBL;
        }

        [HttpGet(Name = "GetTasks")]
        public async Task<IActionResult> GetTasks()
        {
            var username = User.FindFirst(ClaimTypes.Name)?.Value;
            return Ok(await _taskBL.GetTaskItemsAsync(username));
        }


                
    }
}
