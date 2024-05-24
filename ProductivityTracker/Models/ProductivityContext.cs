using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ProductivityTracker.Models;

internal class ProductivityContext : DbContext
{
    public DbSet<StudySession> StudySession { get; set; }
    public DbSet<Workout> Workout { get; set; }
    public DbSet<Exercise> Exercise { get; set; }
    public DbSet<Run> Run { get; set; }
    public DbSet<ReadingSession> ReadingSession { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
    }
}
