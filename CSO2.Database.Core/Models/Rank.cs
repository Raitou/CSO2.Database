using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSO2.Database.Core.Models
{
    public class Rank
    {
        [Key]
        public int Id { get; set; }

        public ulong LowerExp { get; set; }

        public ulong UpperExp { get; set; }

        /***
         * Id   LowerExp    UpperExp
         * 1    0           859
         * 2    860         4092
         * 3    4093        10190
         * ...
         * ...
         * x    y           z
         * x2   z+1 = y     z2
         */

    }
}
