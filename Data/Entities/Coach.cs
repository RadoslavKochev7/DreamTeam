using DreamTeam.Data.Enums;

namespace DreamTeam.Data.Entities
{
    public class Coach : Person
    {
        public virtual Team? Team { get; set; }

        public int? TeamId { get; set; }

        public ExperienceLevelType ExperienceLevel { get; set; }
    }
}