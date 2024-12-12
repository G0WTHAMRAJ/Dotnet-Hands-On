using System.Reflection;
using Microsoft.EntityFrameworkCore;
using MVCProject.Models;

namespace MVCProject
{
    public class EmployeeDBContext : DbContext
    {


        public DbSet<Employeecs> Employees { get; set; }
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options)
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
