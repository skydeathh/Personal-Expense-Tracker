namespace PersonalExpenseTracker.Core.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastLoginDate { get; set; }

        public ICollection<Category> Categories { get; set; }
        public ICollection<Transaction> Transactions { get; set; }
    }
}
