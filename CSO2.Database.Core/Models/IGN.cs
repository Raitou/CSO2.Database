using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSO2.Database.Core.Models
{
    [Keyless]
    public class IGN
    {
        public User User { get; set; } = null!;

        [Required]
        public string Name { get; set; } = null!;

        public DateTime? Updated { get; set; }
    }
}
