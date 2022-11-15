using Microsoft.EntityFrameworkCore;
namespace Tuns_Bianca_Lab6.Models
{
    public class ExpenseContext : DbContext
    {
        public ExpenseContext(DbContextOptions<ExpenseContext> options)
            : base(options) 
        { 
        }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<ExpenseDTO> ExpenseDTO { get; set; }
    }
}
