namespace WebAPI.Interfaces
{
    public interface IUsersDB
    {
        Task<List<string>> GetUsersAsync();
    }
}
