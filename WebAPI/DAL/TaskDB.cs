using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.DAL
{
    public class TaskDB : ITaskDB
    {
        public static List<TaskItem> TaskList = new List<TaskItem>
        {
            // Tasks for admin
            new TaskItem { Id = Guid.NewGuid(), IsDone = false, Title = "Implement JWT authentication", Username = "admin" },
            new TaskItem { Id = Guid.NewGuid(), IsDone = true, Title = "Fix CORS issue in API", Username = "admin", PorcentageCompleted = 100 },
            new TaskItem { Id = Guid.NewGuid(), IsDone = false, Title = "Optimize database queries", Username = "admin" },

            // Tasks for user1
            new TaskItem { Id = Guid.NewGuid(), IsDone = false, Title = "Prepare project presentation", Username = "user1" },
            new TaskItem { Id = Guid.NewGuid(), IsDone = true, Title = "Test API endpoints", Username = "user1", PorcentageCompleted = 100 },
            new TaskItem { Id = Guid.NewGuid(), IsDone = false, Title = "Review code consistency", Username = "user1" },

            // Tasks for user2
            new TaskItem { Id = Guid.NewGuid(), IsDone = false, Title = "Analyze API performance bottlenecks", Username = "user2" },
            new TaskItem { Id = Guid.NewGuid(), IsDone = true, Title = "Fix session handling issues", Username = "user2", PorcentageCompleted = 0 },
            new TaskItem { Id = Guid.NewGuid(), IsDone = false, Title = "Configure Swagger security", Username = "user2" }
        };

        public async Task<List<TaskItem>> GetTaskList(String username)
        {
            return TaskList;
        }

        public Task<TaskItem> InsertTaskAsync(TaskItem task)
        {
            throw new NotImplementedException();
        }
    }


}
