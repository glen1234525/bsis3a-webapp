using bsis3a_webapp.Models;
using Microsoft.EntityFrameworkCore;

namespace bsis3a_webapp.Data
{
    public class ApplicationDbContext : DbContext
    {
       public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
       base (options)
       {
           
       }

       public DbSet<Item> Items { get; set; }
       public DbSet<Type> Types { get; set; }
    }
}