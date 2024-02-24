using _6.Models;
using Microsoft.EntityFrameworkCore;

//create a movie context file to connect models to the database
namespace Mission06_Sorensen.Models
{
    public class MovieFormContext : DbContext
    {
        public MovieFormContext(DbContextOptions<MovieFormContext> options) : base (options) //constuctor 
        {
        
        }

        public DbSet<Movies> Movies { get; set; }
        public DbSet<Category> Category { get; set; }

    }
}
