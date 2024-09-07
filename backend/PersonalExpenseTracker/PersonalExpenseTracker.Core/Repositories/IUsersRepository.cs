using PersonalExpenseTracker.Core.Entities;

namespace PersonalExpenseTracker.Core.Repositories
{
    public interface IUsersRepository
    {
        public Task AddUser(User user);
        public Task UpdateUser(User user);
        public Task DeleteUser(User user);
        public Task<User> GetUserByEmail(string email);
        public Task LoginAsync(string emailOrUsername, string passwordHash);
    }
}
