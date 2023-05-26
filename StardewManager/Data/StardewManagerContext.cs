using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StardewManager.Models;

namespace StardewManager.Data
{
    public class StardewManagerContext : DbContext
    {
        public StardewManagerContext (DbContextOptions<StardewManagerContext> options)
            : base(options)
        {
        }

        public DbSet<Farm> Farms { get; set; }
    }
}
