using System.Data.Entity;

namespace Developer_Challenge.Models
{
    public class AwardContext : DbContext
    {
        public AwardContext() : base("name=AwardContext")
        {

        }

        public DbSet<Award> Awards { get; set; }
    }
}