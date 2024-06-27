using Microsoft.EntityFrameworkCore;
using TestAssignment.Models;

namespace TestAssignment
{
    public sealed class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-4HEINNT;Database=TestAssignmentDb;Trusted_Connection=True;");
        }

        public DbSet<DataModel> DataTable { get; set; }
    }
}
