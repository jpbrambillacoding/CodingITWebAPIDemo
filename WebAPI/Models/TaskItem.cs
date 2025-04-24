namespace WebAPI.Models
{
    public class TaskItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public bool IsDone { get; set; }
        public string Username { get; set; }
    }
}
