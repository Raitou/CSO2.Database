using Microsoft.EntityFrameworkCore;

namespace CSO2.Database.Core.Data
{
    public class MySQLContext : BaseDBContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            MySqlServerVersion serverVersion = new MySqlServerVersion(new Version(8, 0, 29));
            optionsBuilder
                .UseMySql("server=localhost;database=CSO2.Database.Core.Data.CSO2Context;user=root;password=1234", serverVersion); // TODO: Move to config file

        }

    }
}
