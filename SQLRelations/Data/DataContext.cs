using Microsoft.EntityFrameworkCore;
using SQLRelations.Models;

namespace SQLRelations.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }

        public DbSet<Size> sizes { get; set; }
    }
}