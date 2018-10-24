using Microsoft.EntityFrameworkCore;
using RetailPro.Backend.Areas.UserSpace.Models;

namespace RetailPro.Backend.Areas.UserSpace.DbContexts
{
    public class PlaceholderDbContext : DbContext
    {
        public PlaceholderDbContext(DbContextOptions<PlaceholderDbContext> dbContextOptions)
            : base(dbContextOptions)
        { }
    }
}
