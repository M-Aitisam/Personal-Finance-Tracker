using Microsoft.EntityFrameworkCore;
using Personal_Finance_Tracker.Data;

namespace Personal_Finance_Tracker.Data
{
    public class FinanceTrackerDbContext : DbContext
    {
        public FinanceTrackerDbContext(DbContextOptions<FinanceTrackerDbContext> options) : base(options) { }

        public DbSet<Expense> Expenses { get; set; }
    }
}
