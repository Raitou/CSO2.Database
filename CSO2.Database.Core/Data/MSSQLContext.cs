using Microsoft.EntityFrameworkCore;

namespace CSO2.Database.Core.Data
{
    public class MSSQLContext : BaseDBContext
    {
        public MSSQLContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=CSO2.Database.Core.Data.CSO2Context;Integrated Security=True;"); // TODO: Move to config file

        }

    }
}
