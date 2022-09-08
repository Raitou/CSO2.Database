using CSO2.Database.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSO2.Database.Core.Data
{
    public class MSSQLContext : BaseDBContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=CSO2.Database.Core.Data.CSO2Context;Integrated Security=True;"); // TODO: Move to config file

        }

    }
}
