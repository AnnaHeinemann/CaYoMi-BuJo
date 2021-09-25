using DataModel;
using Microsoft.EntityFrameworkCore;

// Reminder:
// Switch to DataAccess project path
// Clean-Up Migration: run 'dotnet ef migrations remove' in console DataAcces.proj
// Create new Migration: run 'dotnet ef migrations add [name of migration]'

namespace DataAccess
{
    public class BuJoContext : DbContext
    {
        public BuJoContext()
        {
            
            Database.Migrate();
        }

        public BuJoContext(DbContextOptions<BuJoContext> options) : base(options)
        {
        }

        public DbSet<JournalPageEntity> JournalPages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JournalPageEntity>().ToTable("JournalPage");
        }        
    }
}
