using Microsoft.EntityFrameworkCore;
using Worker.Entities.Concrete;

namespace Worker.DataAccess.Concrete.EntityFramework
{
    public class WorkerContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=WorkerDb; Trusted_Connection=True");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<WebSettings> WebSettings { get; set; }
    }
}
