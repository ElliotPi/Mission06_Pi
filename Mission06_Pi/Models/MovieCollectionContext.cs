using Microsoft.EntityFrameworkCore;

namespace Mission06_Pi.Models
{
    public class MovieCollectionContext : DbContext
    {
        public MovieCollectionContext(DbContextOptions<MovieCollectionContext> options) : base (options) 
        { 
        }

        public DbSet<MovieCollectionModel> MovieCollections { get; set; }
    }
}
