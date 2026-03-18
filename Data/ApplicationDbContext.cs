using FebBatch2026WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FebBatch2026WebApi.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option):base(option)
        {
            
        }
        public DbSet<Emp> emps { get; set; }
        public DbSet<Manager> managers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Emp>(e =>
            {
                e.HasOne(x => x.managers)
                .WithMany(x => x.emps)
                .HasForeignKey(x => x.mid)
                .OnDelete(DeleteBehavior.Restrict);


            });
        }
    }
}
