using System.Data.Entity;

namespace Developer_Challenge.Models
{
    public class GenreContext: DbContext
    {
        public GenreContext() : base("name=GenreContext")
        {

        }

        public DbSet<Genre> Genres { get; set; }
    }
}