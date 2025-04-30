using Microsoft.AspNetCore.Mvc;
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

        [HttpPost(Name = "AddTask")]
        public async Task<IActionResult> AddTask(String taskTitle)
        {
            var username = User.FindFirst(ClaimTypes.Name)?.Value;

            var task = new TaskItem
            {
                Id = Guid.NewGuid(),
                Title = taskTitle,
                IsDone = false,
                PorcentageCompleted = 0,
                Username = username
            };

            return Ok(await _taskBL.InsertTaskAsync(task));
        }
    }
}
