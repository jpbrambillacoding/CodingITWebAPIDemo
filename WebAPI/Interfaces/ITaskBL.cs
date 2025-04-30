using WebAPI.Models;

namespace WebAPI.Interfaces
{
    public interface ITaskBL
    {
        Task<List<TaskItem>> GetTaskItemsAsync(String username);
        Task<TaskItem> InsertTaskAsync(TaskItem item);
    }
}
