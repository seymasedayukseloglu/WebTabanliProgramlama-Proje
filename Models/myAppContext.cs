using Florals.Models;
using Microsoft.EntityFrameworkCore;

namespace Florals.Models
{
    public class myAppContext : DbContext
    {
        public myAppContext(DbContextOptions<myAppContext> options) : base(options)
        {
        }

       public DbSet<User> Users { get; set; }
       public DbSet<Product> Products { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conStr = "server=DESKTOP-I8M96TV\\SQLEXPRESS; uid=sa; password=pass; database=FloralsDB; TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(conStr);
        }
    }


}