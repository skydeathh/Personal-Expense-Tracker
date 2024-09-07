using PersonalExpenseTracker.Core.Entities;

namespace PersonalExpenseTracker.Core.Repositories
{
    public interface IBudgetRepository
    {
        Task AddBudgetAsync(Budget budget);
        Task UpdateBudgetAsync(Budget budget);
        Task DeleteBudgetByIdAsync(int budgetId);
        Task<Budget> GetBudgetByIdAsync(int budgetId);
        Task<Budget> GetBudgetByCategoryNameAsync(string categoryName);
    }
}
