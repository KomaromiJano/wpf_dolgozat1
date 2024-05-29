using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data
{
    public class UsersContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public UsersContext()
        {
        }
        
        // id auto generate?
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conn = "Server=komacloud.synology.me;User Id=jano;Password=Katica.bogar2002;Database=schoolpaper";
            optionsBuilder.UseMySql(conn, ServerVersion.AutoDetect(conn));
        
            // MSSQL: optionBuilder.UseSqlServer("Server=(localdb)\MSSQLLocalDB;Database=schoolpaper;") 
        }
    }
}