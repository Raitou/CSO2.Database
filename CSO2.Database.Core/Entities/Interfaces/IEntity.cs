using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSO2.Database.Core.Entities.Interfaces
{
    internal interface IEntity
    {
        public int Id { get; }

        public DateTime Created { get; }

        public DateTime? Updated { get; }
    }
}
