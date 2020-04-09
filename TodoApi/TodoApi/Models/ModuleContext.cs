using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class ModuleContext : DbContext
    {
        public ModuleContext(DbContextOptions<ModuleContext> options)
            : base(options)
        {
        }

        public DbSet<ModuleItem> Module { get; set; }
    }
}
