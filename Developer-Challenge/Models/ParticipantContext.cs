using System.Data.Entity;

namespace Developer_Challenge.Models
{
    public class ParticipantContext : DbContext
    {
        public ParticipantContext() : base("name=ParticipantContext")
        {

        }

        public DbSet<Participant> Participants { get; set; }
    }
}