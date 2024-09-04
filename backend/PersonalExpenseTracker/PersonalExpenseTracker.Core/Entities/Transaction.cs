namespace PersonalExpenseTracker.Core.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public int CategoryId { get; set; }
        public decimal Amount { get; set; }
        public  string Description { get; set; }
        public DateTime Date { get; set;}
    }
}
