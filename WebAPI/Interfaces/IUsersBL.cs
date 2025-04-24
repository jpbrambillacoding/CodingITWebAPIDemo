namespace WebAPI.Interfaces
{
    public interface IUsersBL
    {
        Task<List<string>> GetUsersAsync();
    }
}
