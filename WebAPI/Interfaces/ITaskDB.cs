using WebAPI.Models;

namespace WebAPI.Interfaces
{
    public interface ITaskDB
    {
        Task<List<TaskItem>> GetTaskList(String username);
        Task<TaskItem> InsertTaskAsync(TaskItem task);
    }
}
