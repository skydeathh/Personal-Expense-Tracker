﻿namespace PersonalExpenseTracker.Core.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
