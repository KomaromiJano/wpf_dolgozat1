// See https://aka.ms/new-console-template for more information

using Backend.Data;
using Backend.Models;

// first time read user tin csv and save the databade
// second time read the database and write to csv
namespace Backend
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (var db = new UsersContext())
            {
                await db.Database.EnsureCreatedAsync();
                if (!db.Users.Any())
                {
                    // public User(String[] data)

                    var users = new List<User>();
                    string[] lines = System.IO.File.ReadAllLines(@"c:\csv\4.csv").Skip(1).ToArray();
                    foreach (string line in lines)
                    {
                        string[] data = line.Split(";");
                        
                        Console.WriteLine(data[0]);
                        
                        db.Users.Add(new User(data));
                        db.SaveChanges();
                    }
                }
            }
        }
    }
}
