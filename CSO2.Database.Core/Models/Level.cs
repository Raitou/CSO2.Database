using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSO2.Database.Core.Models
{
    public class Level
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public User User { get; set; } = null!;

        [Required]
        public Rank Rank { get; set; } = null!;

        public ulong CurrExp { get; set; } = 0;
    }
}
