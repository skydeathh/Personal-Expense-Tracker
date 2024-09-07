using PersonalExpenseTracker.Core.Entities;

namespace PersonalExpenseTracker.Core.Repositories
{
    public interface IUsersRepository
    {
        Task AddUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task DeleteUserAsync(User user);
        Task<User> GetUserByEmailAsync(string email);
        Task LoginAsync(string emailOrUsername, string passwordHash);
    }
}
