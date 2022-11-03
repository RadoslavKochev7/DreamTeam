using System.ComponentModel.DataAnnotations;

namespace DreamTeam.Data.Entities
{
    /// <summary>
    /// Basketball team, made of Players and a Coach.
    /// </summary>
    public class Team
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Team name.
        /// </summary>
        [Required]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The available positions in a Team. By default they will be 10.
        /// </summary>
        [Required]
        public int OpenPositions { get; set; }

        /// <summary>
        /// Team coach. Can be null.
        /// </summary>
        public virtual Coach? Coach { get; set; }

        public int? CoachId { get; set; }

        /// <summary>
        /// List of all players in the team.
        /// </summary>
        public virtual IEnumerable<BasketballPlayer> Players { get; set; } = new List<BasketballPlayer>();
    }
}