using WebAPI.Interfaces;

namespace WebAPI.DAL
{
    public class UsersDB : IUsersDB
    {
        public Task<List<string>> GetUsersAsync() => Task.FromResult(new List<string> { "admin", "user1", "user2" });
    }
}
