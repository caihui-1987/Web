using Microsoft.EntityFrameworkCore;
using Web1.Models;

namespace Web1.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<UsersModel> Users{ get; set; }
        
    }
}
