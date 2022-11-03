using System.ComponentModel.DataAnnotations;

namespace DreamTeam.Data.Entities
{
    public abstract class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; } = null!;

        [Required]
        public string LastName { get; set; } = null!;
    }
}
