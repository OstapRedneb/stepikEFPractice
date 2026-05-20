using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

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
    public DbSet<CertificateSetting> CertificateSettings {get; set;}
    public DbSet<CourseAuthor> CourseAuthors {get; set;}
    public DbSet<Progress> Progresses {get; set;}
    public DbSet<UnitLesson> UnitLessons {get; set;}
    public DbSet<UserCourse> UserCourses {get; set;}

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
