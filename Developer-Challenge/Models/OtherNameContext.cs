using System.Data.Entity;

namespace Developer_Challenge.Models
{
    public class OtherNameContext : DbContext
    {
        public OtherNameContext() : base("name=OtherNameContext")
        {

        }

        public DbSet<OtherName> OtherNames { get; set; }
    }
}