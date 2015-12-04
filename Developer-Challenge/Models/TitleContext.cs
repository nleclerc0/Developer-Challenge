using System.Data.Entity;

namespace Developer_Challenge.Models
{
    public class TitleContext : DbContext
    {
        public TitleContext() : base("name=TitleContext")
        {

        }

        public DbSet<Title> Titles { get; set; }
    }
}
