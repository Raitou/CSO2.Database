using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSO2.Database.Core.Models
{
    public class Currency
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public User User { get; set; } = null!;

        public ulong CashPoints { get; set; } = 0;

        public ulong GamePoints { get; set; } = 0;

        public ulong MPoints { get; set; } = 0;
    }
}
