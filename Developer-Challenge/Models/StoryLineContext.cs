using System.Data.Entity;

namespace Developer_Challenge.Models
{
    public class StoryLineContext : DbContext
    {
        public StoryLineContext() : base("name=StoryLineContext")
        {

        }

        public DbSet<StoryLine> StoryLines { get; set; }
    }
}