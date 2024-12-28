using System.Reflection;
using CoreApiEFProject.Model;
using Microsoft.EntityFrameworkCore;

namespace CoreApiEFProject
{
    public class PetDBContext:DbContext
    {
        public PetDBContext(DbContextOptions options) : base(options) { }

        public DbSet<PetAnimal> PetAnimals { get; set; }

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

