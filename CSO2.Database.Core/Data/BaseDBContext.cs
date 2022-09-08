using CSO2.Database.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSO2.Database.Core.Data
{
    public class BaseDBContext : DbContext
    {
        public DbSet<User> User { get; set; } = null!;
        public DbSet<IGN> IGN { get; set; } = null!;
        public DbSet<Currency> Currency { get; set; } = null!;
        public DbSet<Level> Level { get; set; } = null!;
        public DbSet<Rank> Rank { get; set; } = null!;
    }
}
