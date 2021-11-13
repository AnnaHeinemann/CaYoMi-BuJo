using DataModel;
using Microsoft.EntityFrameworkCore;

// Reminder:
// Switch to DataAccess project path
// Clean-Up Migration: run 'dotnet ef migrations remove' in console DataAcces.proj
// Create new Migration: run 'dotnet ef migrations add [name of migration]'

namespace DataAccess
{
    /// <summary>
    /// Database of the bullet journal
    /// </summary>
    public class BuJoContext : DbContext
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public BuJoContext()
        {            
            //Database.Migrate();
        }

        /// <summary>
        /// Constructor using database context options given to base
        /// </summary>
        /// <param name="options"></param>
        public BuJoContext(DbContextOptions<BuJoContext> options) : base(options) {}

        /// <summary>
        /// Set of journal page entities
        /// </summary>
        public DbSet<JournalPageEntity> JournalPages { get; set; }

        /// <summary>
        /// Creates the entity model for journal pages
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JournalPageEntity>().ToTable("JournalPage");
        }        
    }
}
