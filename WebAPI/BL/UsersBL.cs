using WebAPI.Interfaces;

namespace WebAPI.BL
{
    public class UsersBL : IUsersBL
    {
        private readonly IUsersDB _usersDB;

        public Task<List<string>> GetUsersAsync()
        {
            return _usersDB.GetUsersAsync();
        }
    }
}
