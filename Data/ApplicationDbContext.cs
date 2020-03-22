using Microsoft.EntityFrameworkCore;
using TelerikThomas.Models;

namespace TelerikThomas.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Person> Customers { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder builder)
        {



            base.OnModelCreating(builder);
        }

    }
}