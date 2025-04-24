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

        public async Task<List<TaskItem>> GetTaskItemsAsync()
        {
            var tasks = await _taskDB.GetTaskList();

            return tasks;
        }
    }
}
