using PersonalExpenseTracker.Core.Entities;

namespace PersonalExpenseTracker.Core.Repositories
{
    public interface ITransactionsRepository
    {
        Task AddTransactionAsync(Transaction transaction);
        Task UpdateTransactionAsync(Transaction transaction);
        Task DeleteTransactionAsync(int id);
        Task<Transaction> GetTransactionsByCategoryAsync(string category);
    }
}
