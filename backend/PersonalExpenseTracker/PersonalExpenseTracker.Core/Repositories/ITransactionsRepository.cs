using PersonalExpenseTracker.Core.Entities;

namespace PersonalExpenseTracker.Core.Repositories
{
    public interface ITransactionsRepository
    {
        public Task AddTransaction(Transaction transaction);
        public Task UpdateTransaction(Transaction transaction);
        public Task DeleteTransaction(Transaction transaction);
        public Task<Transaction> GetTransactionsByCategory(string category);
    }
}
