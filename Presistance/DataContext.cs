using Microsoft.EntityFrameworkCore;
using Domain;

namespace Presistance
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Activity> Activities {get;set;}
    }
}