using CSO2.Database.Core.Entities.Base;
using CSO2.Database.Core.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSO2.Database.Core.Entities.Users
{
    public class Nickname : Entity, INickname
    {
        public string Name { get; set; } = null!;
    }
}
