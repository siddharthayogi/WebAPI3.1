using DAL.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DAL
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {

        }

        // The DbSet property will tell EF Core that we have a table that needs to be created
        public virtual DbSet<Department> Departments { get; }
        public virtual DbSet<Employee> Employees { get; }


        // On model creating function will provide us with the ability to manage the tables properties
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
