using Microsoft.EntityFrameworkCore;
using RetailPro.Backend.Areas.UserSpace.Models;

namespace RetailPro.Backend.Areas.UserSpace.DbContexts
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> dbContextOptions)
            : base(dbContextOptions)
        { }

        public DbSet<User> Users { get; set; }
    }
}
