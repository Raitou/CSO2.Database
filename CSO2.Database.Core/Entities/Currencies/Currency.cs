using CSO2.Database.Core.Entities.Base;
using CSO2.Database.Core.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSO2.Database.Core.Entities.Currencies
{
    public class Currency : Entity, ICurrency
    {
        public int CashPoints { get; set; }

        public int MallPoints { get; set; }

        public int GamePoints { get; set; }
    }
}
