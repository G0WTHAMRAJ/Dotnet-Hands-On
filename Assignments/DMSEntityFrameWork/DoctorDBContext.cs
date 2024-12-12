using System.Reflection;
using DMSEntityFrameWork.Models;
using Microsoft.EntityFrameworkCore;

namespace DMSEntityFrameWork
{
    public class DoctorDBContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DoctorDBContext(DbContextOptions<DoctorDBContext> options) : base(options) { }



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

