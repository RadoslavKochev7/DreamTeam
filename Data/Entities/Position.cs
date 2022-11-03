using System.ComponentModel.DataAnnotations;

namespace DreamTeam.Data.Entities
{
    /// <summary>
    /// Player's position.
    /// </summary>
    public class Position
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Position name.
        /// </summary>
        [Required]
        public string Name { get; set; } = null!;

        public string Initials { get; set; }
    }
}