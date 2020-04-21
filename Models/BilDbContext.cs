using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDataBaseCodeFirst.LAB.Models
{
    public class BilDbContext : DbContext
    {
        public BilDbContext(DbContextOptions<BilDbContext> options)
            : base(options)
        {
        }

        public DbSet<Bil> Bilar { get; set; }
    }
}
