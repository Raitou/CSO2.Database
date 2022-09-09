using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSO2.Database.Core.Entities.Interfaces
{
    public interface ICurrency
    {
        public int CashPoints { get; }

        public int MallPoints { get; }

        public int GamePoints { get; }
    }
}
