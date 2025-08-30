using Microsoft.EntityFrameworkCore;
using PersonalExpenseTracker.Persistence.Entities;

namespace PersonalExpenseTracker.Persistence
{
    public class PETAppDbContext : DbContext
    {
        public PETAppDbContext(DbContextOptions<PETAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
    }
}
