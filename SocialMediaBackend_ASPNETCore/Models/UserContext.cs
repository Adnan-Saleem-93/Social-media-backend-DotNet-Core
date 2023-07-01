using Microsoft.EntityFrameworkCore;

namespace SocialMediaBackend_ASPNETCore.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
