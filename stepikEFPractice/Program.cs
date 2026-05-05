using stepikEFPractice.Data;
using stepikEFPractice.Models;

namespace stepikEFPractice;

class Program
{
    static void Main(string[] args)
    {
        using ApplicationDbContext context = new ApplicationDbContext();

        context.Users.Add(new User());

        context.SaveChanges();
        Console.WriteLine("Sucsess");
    }
}
