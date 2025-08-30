using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace PersonalExpenseTracker.Persistence
{
    public class PETAppDbContextFactory : IDesignTimeDbContextFactory<PETAppDbContext>
    {
        public PETAppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PETAppDbContext>();
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=personal_expense_tracker;Username=postgres;Password=1234");

            return new PETAppDbContext(optionsBuilder.Options);
        }
    }
}
