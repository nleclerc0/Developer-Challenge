using System.Data.Entity;

namespace Developer_Challenge.Models
{
    public class TitleParticipantContext : DbContext
    {
        public TitleParticipantContext() : base("name=TitleParticipantContext")
        {

        }

        public DbSet<TitleParticipant> TitleParticipants { get; set; }
    }
}