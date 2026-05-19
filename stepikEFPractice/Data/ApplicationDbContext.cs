using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using stepikEFPractice.Models;

namespace stepikEFPractice.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<UserSocialProvider> UserSocialProviders { get; set; }
    public DbSet<SocialProvider> SocialProviders { get; set; }
    public DbSet<Unit> Units { get; set; }
    public DbSet<Certificate> Certificates { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<CourseReview> CourseReviews { get; set; }
    public DbSet<Lesson> Lessons { get; set; }
    public DbSet<Step> Steps { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

        string connectionString = config.GetConnectionString("DefaultConnection") ?? throw new Exception("Ошибка в OnConfiguring");

        optionsBuilder
            .UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))
            .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
    }
}
