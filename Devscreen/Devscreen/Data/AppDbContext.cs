
using Devscreen.Model;
using Microsoft.EntityFrameworkCore;

namespace Devscreen.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {
        }

        public DbSet<User> Users;
        public DbSet<Media> Media;
    }
}
