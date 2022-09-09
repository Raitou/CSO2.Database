using CSO2.Database.Core.Entities.Currencies;
using CSO2.Database.Core.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CSO2.Database.Core.Data
{
    public class BaseDBContext : DbContext
    {
        public DbSet<User> User { get; set; } = null!;
        public DbSet<Nickname> Nickname { get; set; } = null!;
        public DbSet<Currency> Currency { get; set; } = null!;

        public BaseDBContext(DbContextOptions options) : base(options) { }
    }
}
