using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class HarbingerContext : DbContext
    {
        public HarbingerContext()
        { }
        public HarbingerContext(DbContextOptions<HarbingerContext> options)
            : base(options)
        {
        }


        public DbSet<MessageDto> Messages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=harbinger;Username=postgres;Password=postgres");
        }

        public override int SaveChanges()
        {
            var entities = ChangeTracker.Entries().Where(x => x.Entity is EntityBase && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entity in entities)
            {
                if (entity.State == EntityState.Added)
                {
                    ((EntityBase) entity.Entity).CreatedAt = DateTime.UtcNow;
                }

                ((EntityBase)entity.Entity).UpdatedAt = DateTime.UtcNow;
            }
            
            return base.SaveChanges();
        }
    }
}