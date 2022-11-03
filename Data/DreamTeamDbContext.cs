using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DreamTeam.Data
{
    public class DreamTeamDbContext : IdentityDbContext
    {
        public DreamTeamDbContext(DbContextOptions<DreamTeamDbContext> options)
            : base(options)
        {
        }
    }
}