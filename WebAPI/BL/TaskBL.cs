using WebAPI.Interfaces;
using WebAPI.Models;

namespace WebAPI.BL
{
    public class TaskBL : ITaskBL
    {
        private readonly ITaskDB _taskDB;

        public TaskBL(ITaskDB taskDB)
        {
            _taskDB = taskDB;
        }

        public async Task<List<TaskItem>> GetTaskItemsAsync(String username)
        {
            var tasks = await _taskDB.GetTaskList(username);

            return tasks;
        }

        public Task<TaskItem> InsertTaskAsync(TaskItem item)
        {
            throw new NotImplementedException();
        }
    }
}
