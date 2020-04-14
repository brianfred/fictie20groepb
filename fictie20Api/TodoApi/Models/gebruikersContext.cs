using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class gebruikersContext : DbContext
    {
        public gebruikersContext(DbContextOptions<gebruikersContext> options)
            : base(options)
        {
        }

        public DbSet<gebruikerItem> Gebruiker { get; set; }
    }
}

