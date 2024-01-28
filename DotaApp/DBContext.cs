using DotaApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DotaApp
{
    class DBContext : DbContext
    {
        public DbSet<Hero> Hero { get; set; }
        public DbSet<DotaApp.Models.Attribute> Attribute { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<TypeAttack> TypeAttack { get; set; }
        public DbSet<GroupItem> GroupItem { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<HeroItem> HeroItem { get; set; }
        public DbSet<Update> Updates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Skill>()
                .Property(s => s.hero_id)
                .HasColumnName("hero_id");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=DESKTOP-N4UDFR9;" +
                "Database=DotaApp;" +
                "Trusted_Connection=True;" +
                "Encrypt=False;" +
                "TrustServerCertificate=False;" +
                "ApplicationIntent=ReadWrite;" +
                "MultiSubnetFailover=False"
                );
        }
    }
}