using System.Reflection;
using CarAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace CarAPI
{
    public class CarDBContext :DbContext
    {

        public DbSet<Car> Cars { get; set; }
        public CarDBContext(DbContextOptions<CarDBContext> options)
     : base(options)
        {
        }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {

            optionsBuilder.UseNpgsql(@"Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=postgres;");

        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);

        }
    }
}

