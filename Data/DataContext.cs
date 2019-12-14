using CityGuide.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CityGuide.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<City> Cities { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Value> Values { get; set; }

    }
}
