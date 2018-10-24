using Microsoft.EntityFrameworkCore;
using RetailPro.Backend.Areas.UserSpace.Models.Contents;

namespace RetailPro.Backend.Areas.UserSpace.DbContexts
{
    public class ContentDbContext : DbContext
    {
        public ContentDbContext(DbContextOptions<ContentDbContext> dbContextOptions)
            : base(dbContextOptions)
        { }

        public DbSet<Content> Contents { get; set; }
        public DbSet<ContentModule> ContentModules { get; set; }
    }
}
