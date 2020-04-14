using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class ActiviteitenroosterContext : DbContext
    {    
        public ActiviteitenroosterContext(DbContextOptions<ActiviteitenroosterContext> options)
            : base(options)
        {
        }
        public DbSet<ActiviteitenroosterItem> Activiteitenrooster { get; set; }
    }
}
