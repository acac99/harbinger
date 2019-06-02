using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class HarbingerContext : DbContext
    {
        public HarbingerContext(DbContextOptions<HarbingerContext> options)
            : base(options)
        {
        }


        public DbSet<Message> Messages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=harbinger;Username=postgres;Password=postgres");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message>().Property(x => x.Id).HasDefaultValue("NEWID()");
        }
    }
}