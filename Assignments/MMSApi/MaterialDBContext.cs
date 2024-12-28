using System.Reflection;
using Microsoft.EntityFrameworkCore;
using MMSApi.Model;

namespace MMSApi
{
    public class MaterialDBContext:DbContext
    {
        public MaterialDBContext (DbContextOptions options) : base(options) { }

        public DbSet <Material> Material { get; set; }
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
