using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSO2.Database.Core.Entities.Interfaces
{
    public interface INickname
    {
        public string Name { get; }

        public DateTime? Updated { get; }
    }
}
