using Microsoft.EntityFrameworkCore;

namespace PrestatieIndicatoren.Models
{
    public class PrestatieIndicatorenContext : DbContext
    {
        public PrestatieIndicatorenContext(DbContextOptions<PrestatieIndicatorenContext> options)
            : base(options)
        {
        }

        public DbSet<PrestatieIndicatorenItem> PrestatieIndicatoren { get; set; }
    }
}