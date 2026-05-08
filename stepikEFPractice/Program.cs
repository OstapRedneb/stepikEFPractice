using Microsoft.EntityFrameworkCore.Storage;
using stepikEFPractice.Data;
using stepikEFPractice.Models;

namespace stepikEFPractice;

class Program
{
    static void Main(string[] args)
    {
        using ApplicationDbContext context = new ApplicationDbContext();

        Console.WriteLine(string.Join('\n', context.Users.Select(user => user.Full_Name)));
        Console.WriteLine("Sucsess");
    }
}
