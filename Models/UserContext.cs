using Microsoft.EntityFrameworkCore;
using System.Linq;
 
namespace wedding.Models
{
    public class UserContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public UserContext(DbContextOptions<UserContext> options) : base(options) { }
	public DbSet<User> Users { get; set; }
	public DbSet<Wedding> Weddings { get; set; }
	public DbSet<Guest> Guest { get; set; }
    }
}