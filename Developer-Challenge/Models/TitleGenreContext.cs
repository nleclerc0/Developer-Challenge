using System.Data.Entity;

namespace Developer_Challenge.Models
{
    public class TitleGenreContext : DbContext
    {
        public TitleGenreContext() : base("name=TitleGenreContext")
        {

        }

        public DbSet<TitleGenre> TitleGenres { get; set; }
    }
}