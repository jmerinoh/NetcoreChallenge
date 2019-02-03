using Microsoft.EntityFrameworkCore;
// using MySQL.Data.EntityFrameworkCore.Extensions;

namespace NetcoreChallenge
{
  public class LibraryContext : DbContext
  {
    public DbSet<Course> Course { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseMySQL("server=localhost;port=8889;database=challenge;user=root;password=root");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<Course>(entity =>
      {
        entity.HasKey(e => e.course_id);
        entity.Property(e => e.name).IsRequired();
      });
    }
  }
}