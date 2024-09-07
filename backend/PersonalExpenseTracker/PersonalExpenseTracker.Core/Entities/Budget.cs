namespace PersonalExpenseTracker.Core.Entities
{
    public class Budget
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public int Mounth { get; set; }
        public int Year { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }


        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
