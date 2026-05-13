using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using stepikEFPractice.Data;
using stepikEFPractice.Models;

namespace stepikEFPractice;

class Program
{
    static void Main(string[] args)
    {
        using ApplicationDbContext context = new ApplicationDbContext();
        context.Database.Migrate();
    }
}
