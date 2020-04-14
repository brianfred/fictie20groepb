using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class ProcesverbaalContext : DbContext
    {
        public ProcesverbaalContext(DbContextOptions<ProcesverbaalContext> options)
            : base(options)
        {
        }

        public DbSet<ProcesverbaalItem> Procesverbaal { get; set; }
    }
}
