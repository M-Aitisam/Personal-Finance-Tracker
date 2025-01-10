namespace Personal_Finance_Tracker.Data
{
    public class Expense
    {
        public int ExpenseId { get; set; }
        public string? Description { get; set; }
        public decimal Amount { get; set; }
        public string? Category { get; set; }
        public DateTime Date { get; set; }
    }
}
