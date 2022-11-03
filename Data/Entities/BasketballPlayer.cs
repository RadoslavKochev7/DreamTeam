using DreamTeam.Data.Enums;

namespace DreamTeam.Data.Entities
{
    public class BasketballPlayer : Person
    {
        public byte JerseyNumber { get; set; }
        public int Height { get; set; }
        public virtual Team Team { get; set; }
        public int TeamId { get; set; }
        public virtual Position Position { get; set; }
        public int PositionId { get; set; }

        public bool IsTeamCaptain { get; set; }
        public bool IsStarter { get; set; }

        public byte SeasonsPlayed { get; set; }

        public ExperienceLevelType ExperienceLevel 
            => this.GetLevelOfExperience();


        private ExperienceLevelType GetLevelOfExperience()
        {
            if (SeasonsPlayed > 10)
            {
                return ExperienceLevelType.Veteran;
            }
            else if (SeasonsPlayed > 3)
            {
                return ExperienceLevelType.Average;
            }

            return ExperienceLevelType.Rookie;
        }

    }
}
