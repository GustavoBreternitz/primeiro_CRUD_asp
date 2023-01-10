using Microsoft.EntityFrameworkCore;

namespace primeiro_CRUD.Models
{
    public class DataBase : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=PrimeiroCrud;integrated Security=True");
        }
    }
}
