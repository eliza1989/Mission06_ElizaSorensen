using Microsoft.EntityFrameworkCore;

namespace Mission06_Sorensen.Models
{
    public class MovieFormContext : DbContext
    {
        public MovieFormContext(DbContextOptions<MovieFormContext> options) : base (options) //constuctor 
        {
        
        }

        public DbSet<Film> Films { get; set; }
    }
}
