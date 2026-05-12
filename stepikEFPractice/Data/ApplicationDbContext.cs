using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using stepikEFPractice.Models;

namespace stepikEFPractice.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<User> Users {get; set;}
    public ApplicationDbContext()
    {
        Database.Migrate();
    }

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
